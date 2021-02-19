namespace SolidPrincips.Core
{
    using Contracts;
    using Classes;
    using SolidPrincips.Factories;
    using System;

    public class Engine : IEngine
    {
        public Engine()
        {
        }
        public void Run()
        {
            IAppender[] appenders = InsertAppenders();

            ILogger logger = new Logger(appenders);

            while (true)
            {
                string data = Console.ReadLine();

                if (data.Contains("END"))
                {
                    break;
                }
                
                LogMessagesFactory factory = new LogMessagesFactory();

                factory.LogMessage(logger, data.Split('|'));
                Console.WriteLine();
            }
            for (int i = 0; i < appenders.Length; i++)
            {
                Console.WriteLine(appenders[i]);
            }
        }
        public static IAppender[] InsertAppenders()
        {
            int n = int.Parse(Console.ReadLine());

            IAppender[] appenders = new IAppender[n];
            AppenderFactory factory = new AppenderFactory();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                appenders[i] = factory.CreateAppender(info);
            }
            return appenders;
        }
    }
}