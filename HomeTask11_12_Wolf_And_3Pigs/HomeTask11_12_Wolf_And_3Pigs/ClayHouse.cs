using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    class ClayHouse : House
    {

        public ClayHouse()
        {
            this.Material = "глина";
            this.Strength = 10000;
            this.timeToMake = 720;
        }
        public override string Describe()
        {
            return $"Надежный прочный дом, в котором можно было бы укрыться от ветра, " +
                $"дождя и мороза должен быть из {this.Material.ReEnd(4, "ы и камней")}.";
        }
        public override string ToString()
        {
            return $"домик из {this.Material.ReEnd(4, "ы и камней")}";
        }
    }
}
