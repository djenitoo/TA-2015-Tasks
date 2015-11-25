using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel.Design;

namespace CalculateSizeOfFiles
{
    public class File
    {
        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name { get; set; }

        public long Size { get; set; }
    }
}