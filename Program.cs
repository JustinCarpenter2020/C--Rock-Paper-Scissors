using System;
using System.Threading;

namespace cSharpRock
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Console.Clear();
            Console.WriteLine(@"
(  _ \(  _  ) / __)( )/ )    (  _ \  /__\  (  _ \( ___)(  _ \    / __) / __)(_  _)/ __)/ __)(  _  )(  _ \/ __)
 )   / )(_)( ( (__  )  ( ()   )___/ /(__)\  )___/ )__)  )   /()  \__ \( (__  _)(_ \__ \\__ \ )(_)(  )   /\__ \
(_)\_)(_____) \___)(_)\_)/   (__)  (__)(__)(__)  (____)(_)\_)/   (___/ \___)(____)(___/(___/(_____)(_)\_)(___/
            
            
            
            ");
            while(running){

            Console.WriteLine(@"
                                            type rock, paper, scissors, or surrender. 
                                                          Choose Wisely
            ");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(4);
            if(userChoice != "surrender")
            {
            if(computerChoice <= 1)
            {
if(userChoice == "rock"){
    Console.WriteLine(@"
                                                    The computer chose Rock
                                                    Great minds think alike
    ");
}
else if (userChoice == "paper")
{
      Console.WriteLine(@"
                                                    The computer chose Paper
                                                    Great minds think alike
    ");
}
else if (userChoice == "scissors") 
{
      Console.WriteLine(@"
                                                    The computer chose scissors
                                                    Great minds think alike
    ");
}
 else
            {
                Console.WriteLine("Invalid pick, you must type rock, paper, or scissors");
            }
            }
            else if(computerChoice == 2)
            {
                if (userChoice == "rock") 
                {
       Console.WriteLine(@"
                                                    The computer chose paper
                                                            You lose
    ");
                }
                else if (userChoice == "paper")
                {
      Console.WriteLine(@"
                                                    The computer chose scissors
                                                            You lose
    ");
                }
                else if (userChoice == "scissors")
                {
      Console.WriteLine(@"
                                                        The computer chose rock
                                                                You lose
    ");
                }
                 else
            {
                Console.WriteLine("Invalid pick, you must type rock, paper, or scissors");
            }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == "rock")
                {
      Console.WriteLine(@"
                                                    The computer chose scissors
                                                              You win
    "); 
                }
                else if (userChoice == "paper")
                {
      Console.WriteLine(@"
                                                    The computer chose rock
                                                             You win
    ");
                }
                 else if (userChoice == "scissors")
                {
      Console.WriteLine(@"
                                                    The computer chose paper
                                                             You win
    ");
                }
                 else
            {
                Console.WriteLine("Invalid pick, you must type rock, paper, or scissors");
                Thread.Sleep(1300);
            }
            }
    } else
    {
        running = false;
    }
            }

            }
}
            }
