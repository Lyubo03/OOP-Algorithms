namespace LectionAlgo
{
    public class Sum
    {
        private int[] arr;
        private int length;
        public Sum(int[] arr)
        {
            this.arr = arr;
            length = arr.Length-1;
        }

        public int SumArray()
        {
            if (length < 0)
            {
                return 0;
            }

            return arr[length--] + SumArray();
        }
    }
}