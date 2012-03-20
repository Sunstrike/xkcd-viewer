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
    }
}
