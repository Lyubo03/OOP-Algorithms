namespace SolidPrincips.Contracts
{
    public interface ILogger
    {
        public IAppender[] Appenders { get; }
        public void Error(string date, string message);
        public void Warning(string date, string message);
        public void Critical(string date, string message);
        public void Fatal(string date, string message);
        public void Info(string date, string message);
    }
}