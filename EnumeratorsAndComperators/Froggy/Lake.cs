namespace Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private int[] stones;
        private IEnumerator<int> enumerator;

        public Lake(int[] stones)
        {
            this.stones = stones;
            enumerator = new MyEnumerator(stones);
        }
        public IEnumerator<int> Enumerator { set { enumerator = value; } }
        public IEnumerator<int> GetEnumerator()
        {
            return enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
//int length = stones.Length;
//for (int i = 0; i < length; i+=2)
//{
//    if (i % 2 == 0)
//    {
//        yield return stones[i];
//    }

//}
//if (stones.Length%2==0)
//{
//    length = stones.Length - 1;
//}
//else
//{
//    length = stones.Length - 2;
//}
//for (int i = length; i >= 0; i -=2)
//{
//    if (i % 2 != 0)
//    {
//        yield return stones[i];
//    }
//}