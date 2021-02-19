namespace Border_Control
{
    public class Robot : IRobot
    {
        public Robot(string model, long id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; }
        public long Id { get; }
    }
}
