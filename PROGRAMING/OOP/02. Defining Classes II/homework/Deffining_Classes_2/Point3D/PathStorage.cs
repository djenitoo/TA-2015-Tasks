namespace Deffining_Classes_2.Point3D
{
    using System;
    using System.Collections.Generic;

    public static class PathStorage
    {
        private static List<Path> storage;

        public static void AddPath(Path path)
        {
            if (storage == null)
            {
                storage = new List<Path>();
            }
            storage.Add(path);
        }

        public static void RemovePath(Path path)
        {
            if (!(storage.Contains(path)))
            {
                throw new ArgumentException("The path for removing is not found!");
            }
            storage.Remove(path);
        }

        public static void SavePaths()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"..\..\Point3D\PathStorageFile.txt"))
            {
                foreach (Path line in storage)
                {
                    file.WriteLine(line.ToString());
                }
            }
        }

        public static void LoadPaths()
        {
            storage.Clear();

            string[] lines = System.IO.File.ReadAllLines(@"..\..\Point3D\PathStorageFile.txt");

            foreach (string line in lines)
            {
                string[] splitLine = line.Split(new char[] {';', ' '} , StringSplitOptions.RemoveEmptyEntries);
                Path tempPath = new Path();

                for (int i = 0; i < splitLine.Length - 2; i = i + 3)
                {
                    tempPath.AddPoint(new Point3D(Convert.ToDouble(splitLine[i]), Convert.ToDouble(splitLine[i + 1]), Convert.ToDouble(splitLine[i + 2])));
                }

                storage.Add(tempPath);
            }
        }

        public static void PrintPathStorage()
        {
            foreach (Path path in storage)
            {
                Console.WriteLine(path.ToString());
            }
        }
    }
}
