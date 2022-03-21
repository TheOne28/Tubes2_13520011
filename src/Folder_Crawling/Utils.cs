using System;
using System.IO;
using System.Collections.Generic;

namespace Folder_Crawling
{
    public static class Utils
    {
        public static string[] getFolders(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(@path);
            DirectoryInfo[] directories = directory.GetDirectories();

            string[] listFolder = new string[directories.GetLength(0)];
            int ptr = 0;
            foreach (DirectoryInfo folder in directories)
            {
                listFolder[ptr] = folder.Name;
                ptr++;
            }
            return listFolder;
        }

        public static string[] getFiles(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(@path);
            FileInfo[] files = directory.GetFiles();

            string[] listFiles = new string[files.GetLength(0)];
            int ptr = 0;
            foreach (FileInfo file in files)
            {
                listFiles[ptr] = file.Name;
                ptr++;
            }
            return listFiles;
        }

    }
}
