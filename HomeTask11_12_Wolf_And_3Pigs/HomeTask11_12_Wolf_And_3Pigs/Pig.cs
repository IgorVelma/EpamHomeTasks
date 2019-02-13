using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    delegate void SeenWolf(object sender, PigArg e);
    class Pig : Hero, GoodHero 
    {
        public event SeenWolf SeeWolfNow;
        public Pig(string pigName)
        {
            this.heroName = pigName;
        }

        public Pig(string pigName, int power) 
        {
            this.heroName = pigName;
            this.power = power;
        }

        public void MakeHouse(House h)
        {
            Console.WriteLine($"Я построю себе {h.ToString()}, решил {this.heroName}.\n".TypeImmit() + h.Describe().TypeImmit());
        }

        public void FearBadHero(Hero h)
        {
            if (SeeWolfNow != null)
            {
                Console.WriteLine($"\nУвидел поросёнок {this.heroName} голодного {h.ToString().ReEnd(4, "а")} и начал убегать с визгом от него...".TypeImmit());
                SeeWolfNow(h, new PigArg(this.heroName));
            }
        }


    }
}
