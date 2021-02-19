namespace BrokerCompanySystem.Models
{
    public interface IBuilding
    {
        public string Name { get; }

        public string City { get; }

        public int Stars { get; }

        public double RentAmount { get; }

        public bool IsAvailable { get; }
    }
}