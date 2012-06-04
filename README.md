#xkcd Viewer
*SQA Coursework 2012-2013*

Simple C#-based viewer and downloader for xkcd comics on Windows. Proof-of-concept built for SQA Advanced Higher in Computing and Information Systems.

## Main components
* Windows Forms front end
* Viewer Core contains the business logic of the front end, managing communication between ASLib and the front end
* Comic Access (ASLib) module to handle individual comics
* Comic Database (ASlib) module to provide SQL Database storage for storing comics and metadata in the filesystem (as one file)

## Design conventions
* Obeys Model-View-Controller convention
	* Model - Contained in Comic Access module
	* View - Windows Forms front end
	* Controller - Viewer Core
* Only uses native assemblies targeted for Windows