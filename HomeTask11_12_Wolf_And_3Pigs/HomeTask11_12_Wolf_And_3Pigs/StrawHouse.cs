using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    class StrawHouse : House
    {
        public StrawHouse()
        {
            this.Material = "солома";
            this.Strength = 15;
            this.timeToMake = 1;
        }
        public override string Describe()
        {
            return $"Что бы построить {this.Material.ReEnd(5, "енный")} домик не нужно много времени.";
        }
        public override string ToString()
        {
            return $"{this.Material.ReEnd(5, "енный")} домик";
        }
    }
}
