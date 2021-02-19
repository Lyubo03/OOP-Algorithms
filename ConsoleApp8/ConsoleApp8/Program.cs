using System;
using System.Linq;
using System.IO;
using System.IO.Compression;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            string picPath = @"D:\Homework\ConsoleApp8\ConsoleApp8\copyMe.png";
            string pathToMakeArchive = @"..\zip.zip";
            using var archive = ZipFile.Open(pathToMakeArchive, ZipArchiveMode.Create);
            archive.CreateEntryFromFile(picPath, Path.GetFileName(picPath));
        }
    }
}
