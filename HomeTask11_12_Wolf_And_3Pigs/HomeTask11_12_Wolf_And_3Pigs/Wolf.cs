using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    class Wolf : Hero, BadHero
    {
        private int countOfWind = 0;
        private const int DAMAGE_TO_ENEMY = 5;
        private const int AMOUNT_OF_POWER_LOSS = 1;
        public Wolf()
        {
            this.heroName = "Волк";
            this.power = 11;
        }
        public Wolf(string wolfName, int power)
        {
            this.heroName = wolfName;
            this.power = power;
        }

        public void BreakDownHouse(House h)
        {
            //while (isWolfAnable() && h.getStrength()>0)
            //{
                ToDamage(h);
                ++this.countOfWind;
            //}
        }

        public void AvoidPig(object sender, PigArg e)
        {
            Console.WriteLine($"Увидел {sender.ToString()}, поросенка {e.ToString().ReEnd(7, "a")} и погнался за ним!".TypeImmit());
        }

        public int getCountOfWind()
        {
            return this.countOfWind;
        }
        public int setCountOfWind(int value)
        {
            return this.countOfWind = value;
        }

        public void KillGoodHero(Hero h)
        {
            Console.WriteLine($"Убил {this.heroName} поросенка {h.ToString()}a и пустил на шашлык...");
        }





        private int ToDamage(House h)
        {
            LosePower(AMOUNT_OF_POWER_LOSS);
            return h.takeDamage(DAMAGE_TO_ENEMY);
        }

        private void LosePower(int quantity)
        {
            this.power -= quantity;
        }
        //private bool isWolfAnable()
        //{
        //    bool isWolfAnable = true;
        //    if (this.power == 0)
        //    {
        //        isWolfAnable = false;
        //    }
        //    return isWolfAnable;
        //}
        private void DescribeToTryBreakDownTheFortness()
        {

        }

    }
}
