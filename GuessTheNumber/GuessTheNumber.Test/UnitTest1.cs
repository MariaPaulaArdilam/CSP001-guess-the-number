using System.Numerics;

namespace GuessTheNumber.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodMakeGuess()
        {

            // Arrange
            var input = new StringReader("42");  // Simula que el usuario introduce "42"
            var output = new StringWriter();
            Console.SetIn(input);
            Console.SetOut(output);

            var player = new HumanPlayer();

            // Act
            int guess = player.makeGuess();

            // Assert
            Assert.AreEqual(42, guess, "El valor devuelto por makeGuess es el esperado.");
        }

        [TestMethod]
        public void TestRangeDiference()
        {
            int RamdonNumber = 5;
            var input = new StringReader("maria\nsi\n45");
            var output = new StringWriter();
            Console.SetIn(input);
            Console.SetOut(output);

            var game = new Game();

            // Act
            string prueba = game.RangeDifference(RamdonNumber);

            // Assert
            Assert.AreEqual("Estás lejos.", prueba);

        }




    
    }

       
}