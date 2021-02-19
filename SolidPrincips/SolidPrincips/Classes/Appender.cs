namespace SolidPrincips.Classes
{
    using Contracts;
    using Enums;
    public abstract class Appender : IAppender
    {
        public Appender(ILayout layout)
        {
            Layout = layout;
        }
        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }
        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}