using Military_Elite.Enums;

namespace Military_Elite.Contracts
{
    public interface IMission
    {
        public State State { get; }
        public string CodeName { get; }
        public void CompletedMissions(string codeName);
    }
}