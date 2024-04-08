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

       


    }
}
