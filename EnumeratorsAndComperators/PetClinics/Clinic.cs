namespace PetClinics
{
    using System;
    using System.Text;

    public class Clinic : IComparable
    {
        private string name;
        private int rooms;
        private Pet[] pets;
        private int index;
        public Clinic(string name, int rooms)
        {
            this.name = name;
            if (rooms % 2 == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            this.rooms = rooms;
            pets = new Pet[rooms];
            index = (rooms + 1) / 2;
        }
        public bool Realise()
        {
            int midleRoom = rooms / 2;
            for (int i = midleRoom; i >= 0; i--)
            {
                if (pets[i] != null)
                {
                    pets[i] = null;
                    return true;
                }
            }
            for (int i = rooms-1; i > midleRoom; i--)
            {
                if (pets[i] != null)
                {
                    pets[i] = null;
                    return true;
                }
            }
            return false;
        }

        public bool HasEmptyRooms()
        {
            for (int i = 0; i < rooms; i++)
            {
                if (pets[i] == null)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Add(Pet pet)
        {
            index--;

            if (index == -1)
            {
                index = rooms - 1;
            }

            if (this.pets[this.index] == null)
            {
                pets[index] = pet;
                return true;
            }

            return false;
        }

        public int CompareTo(object obj)
        {
            if (pets == null)
            {
                return -1;
            }
            return 1;
        }

        public string PrintRoom(int room)
        {
            room--;
            if (pets[room] == null)
            {
                return "Room empty";
            }
            return pets[room].ToString();
        }
        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            for (int room = 0; room < rooms; room++)
            {
                if (pets[room] == null)
                {
                    sb.AppendLine("Room empty");
                }
                else
                {
                    sb.AppendLine(pets[room].ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}