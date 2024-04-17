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
                 // Arrange
            Game game = new Game();
            game.RandomNumber = 10; // Mocking the RandomNumber property
            int number = 10;
            string expectedMessage = "Has adivinado el número.";
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            // Act
            game.RangeDifference(number);
            // Assert
            Assert.AreEqual(expectedMessage, consoleOutput.ToString().Trim());
        }




    
    }

       
}