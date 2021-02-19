namespace SolidPrincips.Factories
{
    using Enums;
    using System;
    public class ReportLevelFactory
    {
        public ReportLevelFactory()
        {

        }
        public ReportLevel GetReportLevel(string level)
        {
            if (level == "CRITICAL")
            {
                return ReportLevel.Critical;
            }
            else if (level == "FATAL")
            {
                return ReportLevel.Fatal;
            }
            else if (level == "INFO")
            {
                return ReportLevel.Info;
            }
            else if (level == "ERROR")
            {
                return ReportLevel.Error;
            }
            else if (level == "WARNING")
            {
                return ReportLevel.Warning;
            }
            throw new ArgumentException("Doesn't exist a report level!");
        }
    }
}