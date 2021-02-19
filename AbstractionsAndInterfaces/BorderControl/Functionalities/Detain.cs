namespace BorderControl
{
    public class Detain
    {
        private string code;
        public Detain(string code)
        {
            this.code = code;
        }
        public bool Detention(string birthdate)
        {
            string lastDigits= null;
            for (int i = 0, poss = birthdate.Length-code.Length; i < code.Length; i++,poss++)
            {
                lastDigits += birthdate[poss];
            }

            if (lastDigits != code)
            {
                return false;
            }
            return true;
        }
    }
}