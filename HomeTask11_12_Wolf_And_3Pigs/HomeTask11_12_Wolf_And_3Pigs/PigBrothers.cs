using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    class PigBrothers : IEnumerable<KeyValuePair<Hero, House>>
    {
        Dictionary<Hero, House> listOfPigs;
        House houseOfPig;

        public PigBrothers()
        {
            listOfPigs = new Dictionary<Hero, House>();
        }


        public void AddPig(Hero hero, House house)
        {
            listOfPigs.Add(hero, house);
            this.houseOfPig = house;
        }
        public House this[Hero hero]
        {
            get
            {
                return getPigHouse(hero);
            }
        }

        public Dictionary<Hero, House>.KeyCollection GetKeys() {

            return listOfPigs.Keys;
        }
        private House getPigHouse(Hero hero)
        {
            House h = null;
            foreach(var pig in listOfPigs)
            {
                if (hero.ToString().Equals(pig.Key.ToString()))
                {
                    h = pig.Value;
                }
            }
            return h;
        }
        public IEnumerator<KeyValuePair<Hero, House>> GetEnumerator()
        {
            foreach(KeyValuePair<Hero, House> pair in listOfPigs)
            {
                yield return pair;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
