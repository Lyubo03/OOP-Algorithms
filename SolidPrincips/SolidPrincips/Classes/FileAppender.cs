namespace SolidPrincips.Classes
{
    using Contracts;
    using Enums;

    public class FileAppender : IAppender
    {
        private int countOfMessages;
        public FileAppender(ILayout layout, LogFile logFile)
        {
            Layout = layout;
            LogFile = logFile;
        }
        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public LogFile LogFile { get; private set; }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= ReportLevel)
            {
                LogFile.Write(string.Format(Layout.Format, dateTime, reportLevel, message));
                countOfMessages++;
            }
        }
        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type:{Layout}, Report level: {ReportLevel.ToString().ToUpper()}, Messages appended: {countOfMessages}, File size: {LogFile.Size}";
        }
    }
}