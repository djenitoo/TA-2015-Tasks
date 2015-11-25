using System;
using System.Collections.Generic;
using System.IO;

namespace TraverseCWindowPath
{
    class TraverseForExeFiles
    {
        static void Main()
        {
            string path = @"C:\WINDOWS";

            //List<string> exeFiles = new List<string>();

            TraverseDirectories(path);

            //Console.WriteLine(string.Join("\r\n", exeFiles));
        }

        static void TraverseDirectories(string dirPath)
        {
            var filePaths = new List<string>();
            try
            {
                filePaths.AddRange(Directory.EnumerateFiles(dirPath, "*.exe"));

                foreach (var file in filePaths)
                {
                    Console.WriteLine(file.Substring(dirPath.Length + 1));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            var directoriesList = Directory.EnumerateDirectories(dirPath);
            try
            {
                foreach (var dir in directoriesList)
                {
                    TraverseDirectories(dir);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
