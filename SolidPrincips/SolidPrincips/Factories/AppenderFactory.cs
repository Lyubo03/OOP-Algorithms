namespace SolidPrincips.Factories
{
    using Contracts;
    using Enums;
    using Classes;
    using System;

    public class AppenderFactory
    {
        public AppenderFactory()
        {
        }
        public IAppender CreateAppender(params string[] info)
        {
            string type = info[0];
            string layoutInfo = info[1];
            IAppender appender = null;

            try
            {
                LayoutFactory layoutFactory = new LayoutFactory();
                ILayout layout = layoutFactory.CreateLayout(layoutInfo);
                if (type == "ConsoleAppender")
                {
                    appender = new ConsoleAppender(layout);
                }
                else if (type == "FileAppender")
                {
                    var file = new LogFile();
                    appender = new FileAppender(layout, file);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            try
            {
                if (info.Length == 3)
                {
                    ReportLevelFactory reportLevelFactory = new ReportLevelFactory();
                    ReportLevel reportLevel = reportLevelFactory.GetReportLevel(info[2]);
                    appender.ReportLevel = reportLevel;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            if (appender != null)
            {
                return appender;
            }

            throw new ArgumentException("Doesn't exist such an appender");
        }
    }
}