using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Game
    {

       
        public int RandomNumber { get; set;}
        public void GenerarNumberRandom()
        {
          Random ramdom =  new Random();
           RandomNumber = ramdom.Next(1, 100);

        }

        public void RangeDifference( int number )
        {
          ;
            int difference = Math.Abs( RandomNumber - number );
            if (difference == 0)
            {
                Console.WriteLine("¡Felicidades! Has adivinado el número.");
            }
            else if (difference <= 5)
            {
                Console.WriteLine("Estás muy cerca.");
            }
            else if (difference <= 10)
            {
                Console.WriteLine("Estás cerca.");
            }
            else
            {
                Console.WriteLine("Estás lejos.");
            }
        }





    }
}
