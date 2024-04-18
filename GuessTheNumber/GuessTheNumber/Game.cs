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

        public bool RangeDifference(int number)
        {
            
            int difference = Math.Abs(RandomNumber - number);
            if (difference == 0)
            {
                Console.WriteLine("Has adivinado el número.");
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

            return true;

         
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
                Console.WriteLine($"Felicitaciones {compu.Name} adivinaste el numero");
                string intentos = string.Join(", ", compu.guesses.Cast<int>());
                Console.WriteLine($"Intentos: {intentos}");
                Console.WriteLine($"Numero de intentos {compu.guesses.Count}");
               
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


   /* Console.WriteLine($"Turnos de {((HumanPlayer)player).Name}: {((HumanPlayer)player).ListGuess.Count}");
                Console.WriteLine($"Nros Intentados por {((HumanPlayer)player).Name}: ");
                Console.WriteLine(string.Join(", ", ((HumanPlayer) player).ListGuess));*/


    }

  

