﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            int number = player.makeGuess();
            RangeDifference(number);

            CompuPlayer compu = new CompuPlayer();
            int numberCompu = compu.makeGuess();
            RangeDifference(numberCompu);

            TurnGame(number, player);
            
        }

        public int RandomNumber { get; set; }
        public void GenerarNumberRandom()
        {
            Random ramdom = new Random();
            RandomNumber = ramdom.Next(1, 100);

        }

        public void RangeDifference(int number)
        {
            ;
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
        }


        public bool TurnGame(int number, Player player)
        {

            while (number != RandomNumber)
            {

                number = player.makeGuess();


                if (number == RandomNumber)
                {
                    Console.WriteLine($"Felicitaciones {player.Name} adivinaste el numero");
                    string intentos = string.Join(", ", player.guesses.Cast<int>());
                    Console.WriteLine($"Intentos: {intentos}");
                    Console.WriteLine($"Numero de intentos {player.guesses.Count}");
                    return true;
                }
            }
            return false;
        }


        //nuevo metodo recibir un numero con rangedifference true si es o false si no r


    }

        
   
}

