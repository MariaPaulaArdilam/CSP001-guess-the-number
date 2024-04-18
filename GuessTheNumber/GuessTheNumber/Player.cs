using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    abstract public class Player
    {
        public String Name { set; get; }
        
        public ArrayList guesses = new ArrayList();

        public abstract int makeGuess();

    }
}
