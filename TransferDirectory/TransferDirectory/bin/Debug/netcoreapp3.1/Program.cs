using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TransferDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dirContaining = Directory.GetFiles(@".", "*.*");
            Dictionary<string, Dictionary<string, double>> fileInfo = new Dictionary<string, Dictionary<string, double>>();
            DirectoryInfo dirInfo = new DirectoryInfo(".");
            FileInfo[] infoNeeded = dirInfo.GetFiles();
            foreach (var item in infoNeeded)
            {
                string nameOfDir = item.Name;
                string nameOfExtension = item.Extension;
                double size = item.Length / 1024d;
                if (!fileInfo.ContainsKey(nameOfExtension))
                {
                    fileInfo[nameOfExtension] = new Dictionary<string, double>();
                }
                if (!fileInfo[nameOfExtension].ContainsKey(nameOfDir))
                {
                    fileInfo[nameOfExtension].Add(nameOfDir, size);
                }
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\report.txt";
            using FileStream writeInfo = new FileStream(path, FileMode.OpenOrCreate);
            foreach (var kvp in fileInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                string extension = kvp.Key + Environment.NewLine;
                byte[] buffer = Encoding.UTF8.GetBytes(extension);
                writeInfo.Write(buffer, 0, buffer.Length);
                foreach (var fileInf in kvp.Value.OrderBy(x => x.Value))
                {
                    string result = $"--{fileInf.Key} - {Math.Round(fileInf.Value, 3)}kb{Environment.NewLine}";
                    buffer = Encoding.UTF8.GetBytes(result);
                    writeInfo.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
