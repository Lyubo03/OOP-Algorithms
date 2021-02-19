namespace Animals
{
    public abstract class Animal : IAnimal
    {
        public string name;
        public string favoriteFood;

        protected Animal(string name, string favoriteFood)
        {
            this.name = name;
            this.favoriteFood = favoriteFood;
        }

        public string Name => this.name;

        public string FavoriteFood => this.favoriteFood;

        public abstract string ExplainSelf();
    }
}