using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class CompuPlayer : Player
    {


        public override int makeGuess()
        {
            Random ramdom = new Random();
            int RandomNumber = ramdom.Next(1, 100);
            Console.WriteLine("Es el turno de la computadora");
            Console.WriteLine(RandomNumber);

          return RandomNumber;
        }
    }
}
