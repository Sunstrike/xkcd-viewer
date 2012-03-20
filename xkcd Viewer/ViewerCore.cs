using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using ASLib;

namespace xkcd_Viewer
{
    class ViewerCore
    {
        // DB Engine and Comic Accessor
        ASComicDatabase dbEngine;
        ASComicAccess.xkcd accessEngine;

        // First runs timer result
        long timerResult = -1;
        
        // Initializer (yes yes, US spelling. Programming convention. I swear.)
        internal ViewerCore()
        {
            // Setup ASLibs components
            dbEngine = new ASComicDatabase(Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") + "\\AppData\\Roaming\\xkcd Viewer\\xkcd.sdf");
            accessEngine = new ASComicAccess.xkcd();
        }
        
        internal void FirstRunSetup()
        {
            // Timing rig
            Debug.WriteLine("[INFO] Beginning first-run initialization.");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            
            // Function start
            dbEngine.createDbFile(); // First run -- DB file will be needed
            
            ASComicAccess.xkcd.ComicMetadata meta = accessEngine.getComic();
            string imgPath = meta.img;

            // Download the image file
            WebClient connectAgent = new WebClient();
            ImageConverter converter = new ImageConverter();
            byte[] rawData;

            try
            {
                rawData = connectAgent.DownloadData(imgPath);
            }
            catch (WebException)
            {
                Debug.WriteLine("[ERROR] WebException thrown - Not connected?");
                return;
            }

            Image img;
            try
            {
                img = (Image)converter.ConvertFrom(rawData);
            }
            catch
            {
                Debug.Fail("[ERROR] Error thrown in image parser");
                throw;
            }

            dbEngine.insertRow(meta);

            if (xkcd_Viewer.Properties.Settings.Default.offlineMode)
                dbEngine.updateImgData(int.Parse(meta.num), img);

            // Function end; stop timer rig
            timer.Stop();
            timerResult = timer.ElapsedMilliseconds;
            Debug.WriteLine("[INFO] Completed first-run initialization in " + timerResult + "ms");
        }

        internal Image getImage(int ID)
        {
            // Simple enough command; call the functions to get images. Have view controller ready to catch NULL values.
            Image img = null;
            
            try
            {
                img = dbEngine.getImageRow(ID); // Try getting from the cache
            }
            catch
            {
                try
                {
                    // Try from download
                    String imgPath = accessEngine.getComic(ID).img; // Get download path
                    img = __downloadImage(imgPath); // Do download

                    // Send for caching if using Offline Mode
                    if (xkcd_Viewer.Properties.Settings.Default.offlineMode)
                        dbEngine.updateImgData(ID, img);
                }
                catch
                {
                    // In case of fail, return NULL
                    img = null;
                }
            }

            return img;
        }

        private Image __downloadImage(string imgPath)
        {
            // Downloads an image file
            byte[] rawData = new WebClient().DownloadData(imgPath);
            // Convert and return
            return (Image)new ImageConverter().ConvertFrom(rawData);
        }

        internal int getMaxID()
        {
            int i = int.Parse(accessEngine.getComic().num); // Grab max ID from latest comic JSON
            return i;
        }

        internal string getTitle(int ID)
        {
            string title;
            
            try
            {
                title = dbEngine.getRow(ID)["safe_title"]; // Try getting from the cache
                if (title == "")
                    throw new Exception();
            }
            catch
            {
                try
                {
                    // Try from download
                    title = accessEngine.getComic(ID).safe_title; // Get title by download
                }
                catch
                {
                    // In case of fail, return NULL
                    title = null;
                }
            }

            return title;
        }
    }
}
