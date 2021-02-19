namespace CryptoMiningSystem
{
    using Components;
    using Interfaces;

    public class ProcessorFactory
    {
        public ProcessorFactory()
        {
            
        }

        public IProcessor CreateProcessor(string processorType, string processorModel, int processorGeneration, double processorPrice)
        {
            IProcessor processor = null;

            if (processorType == "Low")
            {
                return new LowPerformanceProcessor(processorModel, processorGeneration, processorPrice);
            }
            if (processorType == "High")
            {
                return new HighPerformanceProcessor(processorModel, processorGeneration, processorPrice);
            }
            return null;
        }
    }
}