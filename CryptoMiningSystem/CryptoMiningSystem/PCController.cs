namespace CryptoMiningSystem
{
    using Factories;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    public class PCController
    {
        private Dictionary<string, User> users;
        private double daylyBudget;
        public PCController()
        {
            users = new Dictionary<string, User>();
        }
        public string RegisterUser(string name, double money)
        {
            if (!users.ContainsKey(name))
            {
                users[name] = new User(name, money);
                return $"Successfully registered user – {name}!";
            }
            return $"Username: {name} already exists!";
        }
        public string CreateComputer(params string[] data)
        {
            string userName = data[0];

            if (!users.ContainsKey(userName))
            {
                return $"Username: {userName} does not exist!";
            }

            string processorType = data[1];
            string processorModel = data[2];
            int processorGenereration = int.Parse(data[3]);
            double processorPrice = double.Parse(data[4]);

            string videoType = data[5];
            string videoModel = data[6];
            int videoGeneration = int.Parse(data[7]);
            int videoRam = int.Parse(data[8]);
            double videoPrice = double.Parse(data[9]);

            if (users[userName].Money >= processorPrice + videoPrice)
            {
                ProcessorFactory pFactory = new ProcessorFactory();
                IProcessor processor = pFactory.CreateProcessor(processorType, processorModel, processorGenereration, processorPrice);
                if (processor == null)
                {
                    return $"Invalid type processor!";
                }

                VideoCardFactory videoFactory = new VideoCardFactory();
                IVideoCard videoCard = videoFactory.CreateVideoCard(videoType, videoModel, videoGeneration, videoRam, videoPrice);
                if (videoCard == null)
                {
                    return "Invalid type video card!";
                }

                Computer computer = new Computer(processor, videoCard);
                users[userName].Computer = computer;

                return $"Successfully created computer for user: {userName}!";
            }
            return $"Username: {userName} does not exist!";
        }
        public string Mine()
        {
            double minedMoneyForDay = 0;

            foreach (var kvp in users)
            {

                User user = kvp.Value;
                double money = user.Computer.VideoCard.MinedMoneyPerHour * 24;
                minedMoneyForDay += money;
                user.Computer.VideoCard.LifeWorkingHours -= 24;
                user.Computer.Processor.LifeWorkingHours -= 24;
                user.Money += money;
            }
            daylyBudget += minedMoneyForDay;

            return $"Daily profits: {minedMoneyForDay}!";
        }
        public string UserInfo(string name)
        {

            if (users.ContainsKey(name))
            {
                User user = users[name];
                if (user.Computer != null)
                {
                    return $"Name: {name} - Stars: {user.Stars}{Environment.NewLine}Balance: { user.Money}{Environment.NewLine}PC Ram: {user.Computer.Ram}{Environment.NewLine}"
                        + $" - {user.Computer.Processor.GetType().Name} – {user.Computer.Processor.Model} – {user.Computer.Processor.Generation}{Environment.NewLine}" +
                        $" - {user.Computer.VideoCard.GetType().Name} – {user.Computer.VideoCard.Model} – {user.Computer.VideoCard.Generation}{Environment.NewLine}" +
                        $"  * Video card Ram: {user.Computer.VideoCard.Ram}";
                }
                return $"Name: {name} - Stars: {user.Stars}{Environment.NewLine}Balance: { user.Money}";
            }
            return null;
        }
        public string Shutdown()
        {
            foreach (var kvp in users)
            {
                Console.WriteLine(UserInfo(kvp.Key));
            }
            return "System total profits: {totalSystemProts}!!!";
        }
    }
}