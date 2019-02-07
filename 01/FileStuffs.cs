using System;

namespace Application
{
    public class FileStuffs
    {
        private int CountDirectory(System.IO.DirectoryInfo DirInfo)
        {
            int i = 0;
            foreach (System.IO.DirectoryInfo DI in DirInfo.EnumerateDirectories())
            {
                i++;
            }
            return i;
        }
        private int CountFiles(System.IO.DirectoryInfo DirInfo)
        {
            int i = 0;
            foreach (System.IO.FileInfo FI in DirInfo.EnumerateFiles())
            {
                i++;
            }
            return i;
        }

        public void ListDirectory(string Path)
        {
            System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(Path);
            Console.WriteLine("Directories:");
            foreach (System.IO.DirectoryInfo Dir in DirInfo.GetDirectories())
            {
                Console.WriteLine(String.Format("{0} Files: {1} Directories: {2}",
                Dir, CountFiles(Dir), CountDirectory(Dir)));
            }

            Console.WriteLine("\nFiles:");
            foreach (System.IO.FileInfo File in DirInfo.EnumerateFiles())
            {
                Console.WriteLine(String.Format("{0} Length: {1}", File.FullName, File.Length));
            }

        }
    }
}
