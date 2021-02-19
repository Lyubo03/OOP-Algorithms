namespace PetClinics
{
    public class Pet
    {
        private string name;
        private int age;
        private string kind;

        public Pet(string name, int age, string kind)
        {
            this.name = name;
            this.age = age;
            this.kind = kind;
        }
        public void CreatePet(params string[] parameters)
        {
            Pet pet = new Pet(parameters[0], int.Parse(parameters[1]), parameters[2]);
        }
        public override string ToString()
        {
            return $"{name} {age} {kind}";
        }
    }
}
