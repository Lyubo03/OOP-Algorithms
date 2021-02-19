namespace SolidPrincips.Classes
{
    using SolidPrincips.Contracts;

    public class XmlLayout : ILayout
    {
        public string Format => @"<log>
   <data>{0}<data> 
   <level>{1}<level>
   <message>{2}<message>
</log>";
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}