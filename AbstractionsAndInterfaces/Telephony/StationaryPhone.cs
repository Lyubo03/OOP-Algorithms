namespace Telephony
{
    using System;
    using System.Linq;

    public class StationaryPhone : IStationaryPhone
    {
        public StationaryPhone()
        { 

        }
        public string Dialing(string number)
        {
            if (!number.All(ch => char.IsDigit(ch)))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Dialing... {number}";
        }
    }
}
