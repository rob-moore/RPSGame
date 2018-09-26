using System;

namespace RPSGame
{
    internal static class Program
    {
        private enum RPS
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }
        
        public static void Main(string[] args)
        {
            var random = new Random();
            while (true)
            {
                var computerChoice = random.Next(1, 4);
                var computerAnswer = (RPS) computerChoice;

                Console.WriteLine("Input Rock, Paper, or Scissors");
                Enum.TryParse(Console.ReadLine(), true, out RPS answerEnum);
                
                // logic to find winner
                if (computerAnswer == answerEnum)
                {
                    Console.WriteLine("Draw, play again");
                    continue;
                }

                switch (computerAnswer)
                {
                    case RPS.Rock when answerEnum == RPS.Paper:
                        Console.WriteLine("You won, nice!");
                        continue;
                    case RPS.Rock when answerEnum == RPS.Scissors:
                        Console.WriteLine("You lost, too bad!");
                        continue;
                    case RPS.Paper when answerEnum == RPS.Scissors:
                        Console.WriteLine("You won, nice!");
                        continue;
                    case RPS.Paper when answerEnum == RPS.Rock:
                        Console.WriteLine("You lost, too bad!");
                        continue;
                    case RPS.Scissors when answerEnum == RPS.Rock:
                        Console.WriteLine("You won, nice!");
                        continue;
                    case RPS.Scissors when answerEnum == RPS.Paper:
                        Console.WriteLine("You lost, too bad!");
                        continue;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }        
        }
    }
}