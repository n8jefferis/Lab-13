using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class RPSApp
    {
        Random rando = new Random();
        

        public void Run()
        {
            //user player goes here later
            Console.WriteLine("Please Enter your name");
            string input = Console.ReadLine();
            string Name = input;

            User u = new User(Name);
            
            Player opponent = new Rocky("error");
            bool run = true;
            while (run == true)
            {


                Console.WriteLine("Select the oponent Rock or Random");
                string input2 = Console.ReadLine();
                



                if (input2 == "Rocky")
                {
                    opponent = new Rocky("The Rock");
                    
                }
                else if (input2 == "Randy")
                {
                    opponent = new Randy("Randy Marsh", rando);
                    
                }
                else
                {
                    Console.WriteLine("Enter either Rocky or Randy");
                }

               
            
            string userRPS = u.GenerateRoshambo();
            string opponentRPS = opponent.GenerateRoshambo();

            Console.WriteLine($"{u.Name} just threw {userRPS}");
            Console.WriteLine($"Opponent {opponent.Name} threw {opponentRPS}");

            //actual game logic here:
            
                if (userRPS == opponentRPS)
                {
                    Console.WriteLine("Draw!");
                }
                else if (userRPS == RPS.Rock)
                {
                    if (opponentRPS == RPS.Paper)
                    {
                        Console.WriteLine($"Opponent {opponent.Name} wins!");
                    }
                    else if (opponentRPS == RPS.Scissors)
                    {
                        Console.WriteLine("You win!");
                    }
                }
                else if (userRPS == RPS.Scissors)
                {
                    if (opponentRPS == RPS.Paper)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (opponentRPS == RPS.Rock)
                    {
                        Console.WriteLine($"Opponent {opponent.Name} wins!");
                    }
                }
                else if (userRPS == RPS.Paper)
                {
                    if (opponentRPS == RPS.Rock)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (opponentRPS == RPS.Scissors)
                    {
                        Console.WriteLine($"Opponent {opponent.Name} wins!");
                        Console.WriteLine(opponent.Name);
                    }
                }

                Console.WriteLine("Would you like to play again?");
                string cont = Console.ReadLine();
                if (cont == "yes")
                {
                    run = true;
                }
                else if (cont == "no")
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("enter yes or no");
                }

            }
        } 
    }
}
