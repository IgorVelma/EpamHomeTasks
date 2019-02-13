using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    class WoodHouse : House
    {
        public WoodHouse()
        {
            this.Material = "ветка";
            this.Strength = 25;
            this.timeToMake = 3;
        }
        public override string Describe()
        {
            return $"Домик из {this.Material.ReEnd(3, "очек и тонких прутьев")} прочнее и теплее чем соломенный.";
        }
        public override string ToString()
        {
            return $"домик из {this.Material.ReEnd(3, "очек и тонких прутьев")}";
        }
    }
}
