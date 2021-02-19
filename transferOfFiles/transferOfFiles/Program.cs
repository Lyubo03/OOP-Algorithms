using System;
using System.IO;
using System.Text;
using System.Linq;

namespace transferOfFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream stream = new FileStream(@"copyMe.png", FileMode.Open);
            byte[] buffer = new byte[4096];
            using FileStream copyPicture = new FileStream("copiedPicture.png", FileMode.Create);
            while (true)
            {
                int totalBytes = stream.Read(buffer, 0, buffer.Length);
                if (totalBytes < buffer.Length)
                {
                    copyPicture.Write(buffer, 0, totalBytes);
                    break;
                }
                copyPicture.Write(buffer, 0, totalBytes);
            }
        }
    }
}
