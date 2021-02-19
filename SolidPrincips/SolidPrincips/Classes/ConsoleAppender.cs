namespace SolidPrincips.Classes
{
    using System;
    using Contracts;
    using Enums;

    public class ConsoleAppender : IAppender
    {
        private int countOfMessages;
        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
        }
        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }
        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= ReportLevel)
            {
                Console.WriteLine(Layout.Format, dateTime, reportLevel, message);
                countOfMessages++;
            }
        }
        public override string ToString()
        {
           // Appender type: ConsoleAppender, Layout type: SimpleLayout, Report level: CRITICAL, Messages appended: 2
            return $"Appender type: {this.GetType().Name}, Layout type:{Layout}, Report level: {ReportLevel.ToString().ToUpper()}, Messages appended: {countOfMessages}";
        }
    }
}