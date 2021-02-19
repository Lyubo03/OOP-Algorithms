namespace SolidPrincips.Factories
{
    using Contracts;
    public class LogMessagesFactory
    {
        public LogMessagesFactory()
        { 
        }
        public void LogMessage(ILogger logger,params string[] data)
        {
            string type = data[0];
            string dateTime = data[1];
            string message = data[2];

            if (type == "INFO")
            {
                logger.Info(dateTime,message);
                return;
            }
            else if (type == "CRITICAL")
            {
                logger.Critical(dateTime, message);
            }
            else if (type == "ERROR")
            {
                logger.Error(dateTime, message);
                return;
            }
            else if (type == "WARNING")
            {
                logger.Warning(dateTime, message);
                return;
            }
            else if (type == "FATAL")
            {
                logger.Fatal(dateTime, message);
                return;
            }
        }
    }
}