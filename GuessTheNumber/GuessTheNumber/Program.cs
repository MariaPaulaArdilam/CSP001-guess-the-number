// See https://aka.ms/new-console-template for more information
using GuessTheNumber;


Game game = new Game();
game.GenerarNumberRandom();

    Console.WriteLine(game.RandomNumber);



HumanPlayer player = new HumanPlayer();
player.captureName();
player.question();
int number =  player.makeGuess();
game.RangeDifference(number);


CompuPlayer compu = new CompuPlayer();
int numberCompu = compu.makeGuess();
game.RangeDifference(numberCompu);

