using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    abstract class Hero
    {
        protected string heroName;
        protected int power;
        public int getPower()
        {
            return this.power;
        }
        public void setPower(int value)
        {
            this.power = value >= 0 ? value : 0;
        }
        public override string ToString()
        {
            return this.heroName;
        }
    }
}
