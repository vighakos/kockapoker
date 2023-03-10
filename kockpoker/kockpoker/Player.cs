using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kockpoker
{
    class Player
    {
        public string Name;
        public List<int> Hand; // Azok a számok amik őő hát így a játékos megtartja
        public int Rolls;

        public Player(string name)
        {
            Name = name;
            Hand = new List<int>();
            Rolls = 3;
        }

        // Visszaad egy annyi elemű listát, ahány üres hely van a játékos kezében
        // random számok 1-6
        public List<int> Throw
        {
            get
            {
                Random r = new Random();

                List<int> numbers = new List<int>();
                for (int i = 0; i < 5 - Hand.Count; i++)
                {
                    numbers.Add(r.Next(1, 7));
                }

                return numbers;
            }
        }
    }
}
