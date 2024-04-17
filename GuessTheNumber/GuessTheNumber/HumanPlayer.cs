using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class HumanPlayer : Player
    {

        public void captureName()
        {
            Console.WriteLine("Bienvenida al juego de Guess the number");
            Console.Write("Por favor, ingresa tu nombre: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("¡Bienvenida, " + playerName + "!");
            this.Name = playerName;

        } 
        
        public void question()
        {
            Console.WriteLine("¿Estás lista para jugar? (si/no)");
            string respuesta = Console.ReadLine().ToLower();

            while (respuesta != "si" && respuesta != "no")
            {
                Console.WriteLine("Lo siento, no entendí eso. ¿Estás listo para jugar? (si/no)");
                respuesta = Console.ReadLine().ToLower();
            }

            if (respuesta == "no")
            {
                Console.WriteLine("¡Ok, jugaremos en otro momento!");
                return; 
            }

            Console.WriteLine("¡Genial, comencemos el juego!");
        }
        public override int makeGuess()
        {
            Console.WriteLine("Es tu turno," + Name );
            Console.Write("Por favor, introduce un número entre 1 y 100: ");
            string linea = Console.ReadLine();
            int numero;

            bool esNumero = Int32.TryParse(linea, out numero);
            if (esNumero)
            {
                if (numero >= 1 && numero <= 100)
                {
                    this.guesses.Add(numero);
                    Console.WriteLine(numero);
                }
                else
                {
                    Console.WriteLine("El número introducido no está en el rango de 1 a 100.");
                }
            }
            else
            {
                Console.WriteLine("No has introducido un número válido.");
            }

           return numero;
           
        }
    }
}
