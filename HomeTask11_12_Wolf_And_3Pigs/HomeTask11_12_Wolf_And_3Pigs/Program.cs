using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    
    class Program
    {
        /**
         * Скорость написания сказки, (СМЕНИТЬ, ЕСЛИ МЕДЛЕННО ИЛИ БЫСТРО(немного медленнее, рекомендую 100))
         */
        public static int TEMP_OF_READING = 50;
        static void Main(string[] args)
        {
            Console.WriteLine("Теплым летним деньком...".TypeImmit());
            Story story = new Story();
            story.StartStory();
            


            Console.WriteLine("Вот и сказочке конец, а кто слушал молодец!".TypeImmit());
            Console.ReadKey();
        }
    }
}
