using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Game
    {
        public Game()
        {
            GenerarNumberRandom();
            Console.WriteLine(RandomNumber);
            HumanPlayer player = new HumanPlayer();
            player.captureName();
            player.question();
            CompuPlayer compu = new CompuPlayer();
            compu.Name = "Computadora";
            TurnGame( player, compu);
            
        }

        public int RandomNumber { get; set; }
        public void GenerarNumberRandom()
        {
            Random ramdom = new Random();
            RandomNumber = ramdom.Next(1, 100);

        }

        public string RangeDifference(int number)
        {

            int difference = Math.Abs(RandomNumber - number);
            if (difference == 0)
            {
                return "Has adivinado el número.";
            }
            else if (difference <= 5)
            {
                return "Estás muy cerca.";
            }
            else if (difference <= 10)
            {
                return "Estás cerca.";
            }
            else
            {
                return "Estás lejos.";
            }




        }


        public void TurnGame(HumanPlayer player, CompuPlayer compu)
        {
            var turne = 1;
            var number = 0;

            while (number != RandomNumber)
            {
                if (turne % 2 == 0)
                {
                    number = compu.makeGuess();
                    RangeDifference(number);
                    turne++;
                } 
                else
                {
                    number = player.makeGuess();
                    RangeDifference(number);
                    turne++;
                }
            }
            
            if (turne % 2 == 0)
            {
                Console.WriteLine($"Felicitaciones {player.Name} adivinaste el numero");
                string intentos = string.Join(", ", player.guesses.Cast<int>());
                Console.WriteLine($"Intentos: {intentos}");
                Console.WriteLine($"Numero de intentos {player.guesses.Count}");
               
            }
            else
            {
                Console.WriteLine($"Felicitaciones {compu.Name} adivinaste el numero");
                string intentos = string.Join(", ", compu.guesses.Cast<int>());
                Console.WriteLine($"Intentos: {intentos}");
                Console.WriteLine($"Numero de intentos {compu.guesses.Count}");
               
            }
        }  

        }


    }

  

