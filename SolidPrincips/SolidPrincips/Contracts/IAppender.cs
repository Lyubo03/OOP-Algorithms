namespace SolidPrincips.Contracts
{
    using Enums;
    public interface IAppender
    {
        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }
        public void Append(string dateTime,ReportLevel reportLevel, string message);
    }
}