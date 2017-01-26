using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beersong
{
    class BeerSong
    {
         static void Main(string[] args)
        {
           Ninety_Nine_Bottles_of_Beer();
        }
        public static void Ninety_Nine_Bottles_of_Beer()
        {
         for (int i = 99; i > 0; i--)
            {
                Console.WriteLine(i + " bottles of beer on the wall, " + i + " bottles of beer");
                if (!(i == 1))
                {
                    Console.WriteLine("take one down, pass it around, " + (i - 1) + " bottles of beer on the wall.");
                }
                else {
                    Console.WriteLine("take one down, pass it around, no more bottles of beer on the wall.");
                }            

            }
               Console.ReadLine();
        }
    }
}
