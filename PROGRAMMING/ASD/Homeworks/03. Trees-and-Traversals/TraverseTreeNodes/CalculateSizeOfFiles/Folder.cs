using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CalculateSizeOfFiles
{
    public class Folder
    {
        private List<Folder> childFolders;
        private List<File> files;

        public Folder(string name, string fullName)
        {
            this.Name = name;
            this.FullName = fullName;
            this.files = new List<File>();
            this.childFolders = new List<Folder>();
        }

        public string FullName { get; set; }

        public List<Folder> ChildFolders
        {
            get { return this.childFolders; }
        }

        public List<File> Files
        {
            get { return this.files; }
        }  

        public string Name { get; set; }

        public void AddFile(File file)
        {
            this.files.Add(file);
        }

        public void AddFolder(Folder folder)
        {
            this.childFolders.Add(folder);
        }

        public long GetFolderSize()
        {
            return this.files.Sum(f => f.Size) + this.childFolders.Sum(subDir => subDir.GetFolderSize());
        }
    }
}