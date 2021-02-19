namespace SolidPrincips.Classes
{
    using Contracts;
    using Enums;

    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
           //TODO ask for at least one element!
            Appenders = appenders;
        }
        public IAppender[] Appenders { get; }
        public void Critical(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.Critical, message);
        }

        public void Error(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.Error, message);
        }

        public void Fatal(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.Fatal, message);
        }

        public void Info(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.Info, message);
        }

        public void Warning(string dateTime, string message)
        {
           Append(dateTime, ReportLevel.Warning, message);
        }
        private void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            for (int i = 0; i < Appenders.Length; i++)
            {
                Appenders[i].Append(dateTime, reportLevel, message);
            }
        }
    }
}