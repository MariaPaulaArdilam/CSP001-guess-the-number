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
             var input = new StringReader("42");  // Simula que el usuario introduce "42" y luego "respuesta a question"
             var output = new StringWriter();
             Console.SetIn(input);
             Console.SetOut(output);

             var game = new Game();

             // Captura la salida de la consola justo después de llamar a RangeDifference
             string consoleOutput = output.ToString().Split('\n').Last().Trim();

             Assert.AreEqual("Has adivinado el número.", consoleOutput);


            /* Arrange
            Game game = new Game();
            game.RandomNumber = 10; // Mocking the RandomNumber property
            int number = 10;
            string expectedMessage = "Has adivinado el número.";
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            // Act
            game.RangeDifference(number);
            // Assert
            Assert.AreEqual(expectedMessage, consoleOutput.ToString().Trim());*/
        }




    
    }

       
}