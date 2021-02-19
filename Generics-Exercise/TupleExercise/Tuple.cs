using System.Collections.Generic;

namespace TupleExercise
{
    public class Tuple<TOne, TTwo, TThree>
    {
        private TOne item1;
        private TTwo item2;
        private TThree item3;
        public Tuple(TOne item1, TTwo item2, TThree item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }
        public override string ToString()
        {
            string res = $"{this.item1} -> {this.item2} -> {this.item3}";

            return res;
        }
    }
}