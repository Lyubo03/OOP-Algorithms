namespace SolidPrincips.Classes
{
    using Contracts;
    using System;
    using System.IO;
    using System.Linq;

    public class LogFile : ILogFile
    {
        private const string filePath = "../../../log.txt";
        public LogFile()
        {
        }
        public int Size => Calculate();
        public void Write(string toBeWritten)
        {
            File.AppendAllText(filePath, toBeWritten + Environment.NewLine);
        }
        private int Calculate()
        {
            return File.ReadAllText(filePath).Where(char.IsLetter).Sum(x => x);
        }
    }
}