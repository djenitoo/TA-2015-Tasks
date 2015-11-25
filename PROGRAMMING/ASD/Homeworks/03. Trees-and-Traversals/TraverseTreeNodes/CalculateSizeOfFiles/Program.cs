using System;
using System.Collections.Generic;
using System.IO;

namespace CalculateSizeOfFiles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //string path = @"C:\WINDOWS\Help";
            string path = @"C:\WINDOWS";
            var root = new Folder("WINDOWS", path);
            CreadDirectoryTree(root);
            Console.WriteLine("{0} folder size in bytes is: {1}", root.Name, root.GetFolderSize());

        }


        private static void CreadDirectoryTree(Folder folder)
        {
            var dirPath = folder.FullName;
            var filePaths = new List<string>();


            try
            {
                filePaths.AddRange(Directory.GetFiles(dirPath));

                foreach (var file in filePaths)
                {
                    int length = file.Length -
                                 (dirPath.Length + 1 + (file.Length - file.LastIndexOf(".", StringComparison.Ordinal)));
                    folder.AddFile(new File(file.Substring(dirPath.Length + 1, length), new FileInfo(file).Length));
                }
            }
            catch (Exception e)
            {
            }



            try
            {
                var directoriesList = Directory.GetDirectories(dirPath);
                foreach (var dir in directoriesList)
                {
                    var childFolder = new Folder(dir.Substring(dirPath.LastIndexOf("\\") + 1), dir);
                    folder.AddFolder(childFolder);
                    CreadDirectoryTree(childFolder);
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}
