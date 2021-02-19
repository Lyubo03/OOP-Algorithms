using Military_Elite.Contracts;
using Military_Elite.Enums;
namespace Military_Elite.Models
{
    public class Missions : IMission
    {
        public Missions(State state, string codeName)
        {
            State = state;
            CodeName = codeName;
        }
        public State State { get; private set; }

        public string CodeName { get; }

        public void CompletedMissions(string codeName)
        {
            this.State = State.Finished;
        }
    }
}