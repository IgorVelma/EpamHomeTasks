using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    abstract class House
    {
        protected string Material { get; set; }
        protected int Strength { get; set; }
        protected int timeToMake; 

        public abstract string Describe();

        public int takeDamage(int quantity)
        {
            return this.Strength -= quantity;
        }

        public int getTimeToMake()
        {
            return this.timeToMake;
        }

        public int getStrength()
        {
            return this.Strength;
        }

        public string getMaterial() {
            return this.Material;
        }

        public override string ToString()
        {
            return this.Material + " домик";
        }
    }
}
