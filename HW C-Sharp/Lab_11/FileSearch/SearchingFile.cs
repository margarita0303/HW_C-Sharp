using System;
using System.IO;

namespace FileSearch
{
    public class SearchingFile
    {
        public string FindfFile(string filename, DirectoryInfo directoryInfo)
        {
            string currentPath = directoryInfo.FullName + "/" + filename;
            if (File.Exists(currentPath))
            {
                return currentPath;
            }

            var subDirectories = directoryInfo.GetDirectories();
            foreach (DirectoryInfo subDirectoryInfo in subDirectories)
            {
                var filePath = FindfFile(filename, subDirectoryInfo);
                if (filePath == null)
                {
                    continue;
                }
                return filePath;
            }

            return null;
        }
    }
}