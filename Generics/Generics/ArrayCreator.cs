namespace Generics
{
    public class ArrayCreator
    {
        public static Т[] Create<Т>(int length, Т item)
        {
            Т[] arr = new Т[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = item;
            }
            return arr;
        }

    }
}