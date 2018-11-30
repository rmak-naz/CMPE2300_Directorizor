using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2_Directorizor
{
    class SimpleFileInfo : IComparable
    {
        public string DirName { get; private set; }
        public string FileName { get; private set; }
        public long FileLength { get; private set; }
        public DateTime LastModified { get; private set; }

        public static Comparison<SimpleFileInfo> CompareOption = null;

        public SimpleFileInfo(FileInfo file)
            :this(file.DirectoryName, file.Name, file.Length, file.LastWriteTime)
        {
            //DirName = file.DirectoryName;
            //FileName = file.Name;
            //FileLength = file.Length;
            //LastModified = file.LastWriteTime;
        }

        public SimpleFileInfo(string directory, string name, long size, DateTime modified)            
        {
            //Check if file exists, if name is empty, if accessible
            try
            {
                if (!(Directory.Exists(directory)) ||
                    name == "" ||
                    directory == "")
                {
                    throw new ArgumentException();
                }
                else
                {
                    DirName = directory;
                    FileName = name;
                    FileLength = size;
                    LastModified = modified;
                }
            }
            catch
            {
                Console.WriteLine("Cannot access file or doesn't exist.");
            }
        }

        public static List<SimpleFileInfo> GenerateFileList(string dirPath)
        {
            List<SimpleFileInfo> fileList = new List<SimpleFileInfo>();
            DirectoryInfo dir = new DirectoryInfo(dirPath);

            fileList = GetFileInfo(dir);

            foreach (FileInfo file in dir.GetFiles())
            {
                fileList.Add(new SimpleFileInfo(file));
            }

            return fileList;
        }

        public static List<SimpleFileInfo> GetFileInfo(DirectoryInfo dirInfo)
        {
            List<SimpleFileInfo> fileList = new List<SimpleFileInfo>();

            try
            {
                foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                {
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        fileList.Add(new SimpleFileInfo(file));
                    }
                    fileList.AddRange(GetFileInfo(dir));
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }

            return fileList;
        }

        public override string ToString()
        {
            return FileName + " | "  +  DirName + " | " + FileLength + " | " + LastModified; 
        }

        public int CompareTo(object obj)
        {
            if (!(obj is SimpleFileInfo))
            {
                throw new ArgumentException("Incorrect type in SimpleCompare.CompareTo!");
            }

            SimpleFileInfo other = (SimpleFileInfo)obj;

            return (FileName.CompareTo(other.FileName) == 0 ? FileLength.CompareTo(other.FileLength) : FileName.CompareTo(other.FileName));            
        }

        public static int SortByDirectory(SimpleFileInfo file1, SimpleFileInfo file2)
        {
            return (file1.DirName.CompareTo(file2.DirName) == 0 ? file1.FileName.CompareTo(file2.FileName) : file1.DirName.CompareTo(file2.DirName));
        }

        public static int SortByModified(SimpleFileInfo file1, SimpleFileInfo file2)
        {
            return (file1.LastModified.CompareTo(file2.LastModified) == 0 ? file1.FileName.CompareTo(file2.FileName) : file1.LastModified.CompareTo(file2.LastModified));
        }

        public static int SortBySize(SimpleFileInfo file1, SimpleFileInfo file2)
        {
            return (file1.FileLength.CompareTo(file2.FileLength) == 0 ? file1.FileName.CompareTo(file2.FileName) : file1.FileLength.CompareTo(file2.FileLength));
        }

        public override bool Equals(object obj)
        {
            if (!(obj is SimpleFileInfo))
            {
                return false;
            }

            SimpleFileInfo other = (SimpleFileInfo)obj;

            return (other.LastModified == LastModified && other.FileLength == FileLength && other.FileName == FileName);
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
