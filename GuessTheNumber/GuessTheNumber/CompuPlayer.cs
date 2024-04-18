using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            this.guesses.Add(RandomNumber);

            return RandomNumber;
        }
    }
}
