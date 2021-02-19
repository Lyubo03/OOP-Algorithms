namespace SolidPrincips.Classes
{
    using Contracts;
    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}