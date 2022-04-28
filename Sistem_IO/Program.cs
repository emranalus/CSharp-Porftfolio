using System;
using System.IO;
using System.Text;

namespace Sistem_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DriveInfoMethod();
            //CreateFolder(@"C:\MyFolder");

            CreateFile(@"C:\MyFolder\test.txt");

            //Console.WriteLine("Hello World!");
        }

        private static void CreateFile(string FilePath)
        {
            FileStream fi = File.Create(FilePath);
            Byte[] buffer = new UTF8Encoding(true).GetBytes(@"assosknkskslk WEEsEEEEEEEEEEE d");

            fi.Write(buffer);
            fi.Close();

            string fileText = File.ReadAllText(FilePath);
            Console.WriteLine(fileText);
        }

        private static void CreateFolder(string FolderPath)
        {
            // DirectoryInfo => Info about folders and paths from given volume in the system
            string[] dirs = Directory.GetDirectories(@"C:\");
            

            // Create new folder in given path(C:\)
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            // Print C:\ Directory
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
        }

        private static void DriveInfoMethod()
        {
            // DriveInfo => Info about drives in the system.
            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in driveInfos)
            {
                Console.WriteLine(driveInfo.Name);
                Console.WriteLine(driveInfo.TotalSize);
                Console.WriteLine(driveInfo.DriveType);
                Console.WriteLine(driveInfo.DriveFormat);
                Console.WriteLine(driveInfo.TotalFreeSpace);
                Console.WriteLine(driveInfo.IsReady);
            }
        }
    }
}
