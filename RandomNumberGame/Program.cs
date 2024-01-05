namespace RandomNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int hiddenNum = rnd.Next(1, 99);
            Console.WriteLine(hiddenNum);
            int guess = 0;
            bool gameDone = false;
            int attempt = 1;

            bool guessLogic(int guess)
            {
                if (guess == hiddenNum)
                {
                    Console.WriteLine();
                    Console.WriteLine("Correct Number!");
                    return true;
                }
                else if (hiddenNum > guess)
                {
                    Console.WriteLine("The computers hidden number is ABOVE your guess!");
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    Console.WriteLine("The computers hidden number is BELOW your guess!");
                    Console.WriteLine();
                    return false;
                }
            }

            //game loop
            while (gameDone == false)
            {
                if (guessLogic(guess) == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Game Over, YOU WIN!");
                    gameDone = true;
                }
                else if (attempt == 6)
                {
                    //game end, lose
                    Console.WriteLine("The Computers number remains HIDDEN!");
                    Console.WriteLine();
                    Console.WriteLine("Game Over, you lose.");
                    gameDone = true;
                }
                else
                {
                    Console.WriteLine("Attempt Number → {0}", attempt++);

                    Console.WriteLine("Enter in the computers hidden number:");
                    guess = Convert.ToInt16(Console.ReadLine());
                }
            }
        }
    }
}
