namespace SolidPrincips.Factories
{
    using Contracts;
    using Classes;
    using System;

    public class LayoutFactory
    {
        public LayoutFactory()
        {
        }
        public ILayout CreateLayout(string type)
        {
            if (type == "SimpleLayout")
            {
                return new SimpleLayout();
            }
            if (type == "XmlLayout")
            {
                return new XmlLayout();
            }
            throw new ArgumentException("Doesn't exist such a layout");
        }
    }
}