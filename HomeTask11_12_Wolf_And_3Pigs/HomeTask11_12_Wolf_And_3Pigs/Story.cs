using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    class Story
    {
        PigBrothers pigs;
        Pig pig;
        Wolf wolf;
        List<Pig> escapedPig;
        public Story()
        {
            pigs = new PigBrothers();
            wolf = new Wolf();
            this.escapedPig = new List<Pig>();
        }

        private void CreatePigs()
        {
            Thread.Sleep(1000);
            Console.Write("Жили были 3 братца поросёнка ".TypeImmit());

            pigs.AddPig(new Pig("Ниф-Ниф"), new StrawHouse());
            pigs.AddPig(new Pig("Нуф-Нуф"), new WoodHouse());
            pigs.AddPig(new Pig("Наф-Наф"), new ClayHouse());

            foreach (var pig in pigs)
            {
                Console.Write(pig.Key.ToString().TypeImmit() + " ");
                Thread.Sleep(Program.TEMP_OF_READING);
            }
        }

        private void PigsMakeHouses()
        {
            Console.WriteLine("\nРешили поросята построить себе домики: ".TypeImmit());
            foreach (var pig in pigs)
            {
                ((Pig)pig.Key).MakeHouse((pig.Value));
            }
        }
        private void walkToForest()
        {
            Console.WriteLine($"\n{pigs.GetKeys().ElementAt(0)} и {pigs.GetKeys().ElementAt(1)} закончили быстро и решили ".TypeImmit() +
                $"пойти прогулсятся в лес.\nОни громко пели и кричали, что разбудили голодного волка.".TypeImmit());
            meetWithWolf();
            for (int i = 0; i < 2; ++i)
            {
                pig = ((Pig)pigs.GetKeys().ElementAt(i));
                pig.FearBadHero(wolf);
            }
            Console.WriteLine("И разбежались поросята по своим домикам.".TypeImmit());
        }
        private void meetWithWolf()
        {
            ((Pig)pigs.GetKeys().ElementAt(0)).SeeWolfNow += wolf.AvoidPig;
            ((Pig)pigs.GetKeys().ElementAt(1)).SeeWolfNow += wolf.AvoidPig;
        }
        private void actionNearHouses()
        {
            for (int i = 0; i < 3; ++i)
            {
                pig = ((Pig)pigs.GetKeys().ElementAt(i));
                Console.WriteLine($"\nПодошёл {this.wolf.ToString()} к домику {pig.ToString().ReEnd(7, "a")} и сказал:\n".TypeImmit() +
                    $" - Если не выйдешь из своего домика, я его сломаю!\n - Не выйду, сказал {pigs.GetKeys().ElementAt(i).ToString()}.".TypeImmit());
                processToBreakHouse(pig, pigs[pig]);
                Console.WriteLine();

                escapeFromWolf(pigs[pig], pig, i);

            }
        }

        private void processToBreakHouse(Pig pig, House h)
        {

            if (isFortness(h))
            {
                Console.WriteLine($"Домик {pig.ToString().ReEnd(7, "a")} стоял, как крепость! Сколько бы {this.wolf.ToString()} не дул.".TypeImmit());
                while (isWolfAnable())
                {
                    this.wolf.BreakDownHouse(h);
                    storyWolfEnd(this.wolf.getPower());
                }
                Console.WriteLine($"Так поросята и спаслись от {this.wolf.ToString().ReEnd(4, "а")}.\n".TypeImmit());
            }
            else
            {
                while (isWolfAnable() && h.getStrength() > 0)
                {
                    this.wolf.BreakDownHouse(h);
                    Console.WriteLine($"{this.wolf.ToString()} подул {this.wolf.getCountOfWind()} раз: 'Ф-ф-ф-у-у-у'...".TypeImmit());
                }
            }


        }
        private void escapeFromWolf(House h, Pig pig, int iteration)
        {
            if (isBraked(h))
            {
                escapedPig.Add(pig);
                foreach (var chasePig in escapedPig)
                {
                    chasePig.FearBadHero(wolf);
                }
                foreach (var es in escapedPig)
                {
                    if (escapedPig.Count < 2)
                    {
                        Console.Write(es.ToString() + " ");
                    }
                    else
                    {
                        Console.Write(es.ToString() + ", ");
                    }
                }
                Console.WriteLine($"убежал в домик к {pigs.GetKeys().ElementAt(iteration + 1).ToString().ReEnd(7, "у")}".TypeImmit());
            }
        }
        private bool isBraked(House h)
        {
            bool isBraked = false;
            if (h.getStrength() == 0)
            {
                Console.WriteLine($"Когда {this.wolf.ToString()} подул {this.wolf.getCountOfWind()} раз, домик зашатался и развалился...".TypeImmit());
                this.wolf.setCountOfWind(0);
                isBraked = true;
            }
            return isBraked;
        }
        private bool isFortness(House h)
        {
            bool isFortness = true;
            if (h.getStrength() <= 25)
            {
                isFortness = false;
            }
            return isFortness;
        }
        private bool isWolfAnable()
        {
            bool isWolfAnable = true;
            if (this.wolf.getPower() == 0)
            {
                isWolfAnable = false;
            }
            return isWolfAnable;
        }

        private void storyWolfEnd(int power)
        {
            switch (power)
            {
                case 1:
                    Console.WriteLine($"{this.wolf.ToString()} стал от злости царапать когтями стены дома и грызть камни, ".TypeImmit() +
                        $"но только когти себе обломал и зубы испортил.".TypeImmit());
                    Console.WriteLine($"Голодному и злому {this.wolf.ToString().ReEnd(4, "у")} ничего не оставалось делать, как убираться восвояси.".TypeImmit());
                    //this.wolf.setPower(this.wolf.getPower() - 1);
                    break;
                case 2:
                    Console.WriteLine($"{this.wolf.ToString()} начал трясти дверь. Но дверь тоже не поддавалась!".TypeImmit());
                    break;
            }
        }


        public void StartStory()
        {
            CreatePigs();
            PigsMakeHouses();
            walkToForest();
            actionNearHouses();
        }
    }
}
