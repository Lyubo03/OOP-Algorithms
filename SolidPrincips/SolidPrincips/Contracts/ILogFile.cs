using System.Data;
using System.Text;

namespace SolidPrincips.Contracts
{
    public interface ILogFile
    {
        public int Size { get; }

        public void Write(string toBeWritten);
    }
}