#########################################
# Bipul Karki
# CMPE-277, Spring 2014
# IsolatedStorage App in Windows Phone 8
# 
# Read Me 

This app uses IsolatedStorageFile to save the input data into local storage. 

In order to save data into one file, this program uses KeyValuePair
list.

Windows Phone 8 implements IsolatedStorage to sandbox the data to isolated the application's data from outside access.

THIS PROGRAM WAS WRITTEN FOR WP8 IN VISUAL STUDIO 2013 AND WINDOWS 8. 

Requirements
=============
Windows 8 Operating System
Hyper-V Enabled PC for Emulator
Visual Studio 2012-2013

1. Double click on the the visual studio project file in the IsolatedFileStorageApp directory.  
2. When project is loaded in the Visual Studio, click on the Emulator Play button to run the app.
3. Once the app is installed in the Emulator, click on IsolatedFileStorageApp to launch the app.
4. Enter the data into textboxes and click on save.
5. Once save button is pressed the program save the data into IsolatedStorage.
6. If you want to view the downloaded files in IsolatedStorage, you can use IsolatedStorageTool to copy the files
 from Emulator to local PC's file system.