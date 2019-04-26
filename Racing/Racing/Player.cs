using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    class Player
    {
        public string name = "Player";
        public double money = 1000;
        public int rating = 0;
        public Player(int money, int rating,  string name)
        {
            /* initialization */
            this.name = name;
            this.money = money;
            this.rating = rating;
        }

    }
}
