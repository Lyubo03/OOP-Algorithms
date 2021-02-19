namespace Telephony
{
    public interface ISmartphone
    {
        public string Browsing(string URL);
        public string Calling(string number);
    }
}