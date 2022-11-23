namespace RockPaperScissor;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        string player;
        string computer;
        string answer; 


        while (playAgain)
           
        {
            player = "";
            computer = "";
            answer = "";


            while (player != "ROCK" && player != "PAPER" && player != "SCISSOR") {
                Console.Write("Entre ROCK, PAPER or SCISSOR: ");
                player = Console.ReadLine();
                player = player.ToUpper();

                
            }

            int randomNumber = random.Next(1, 4);
            switch(randomNumber)
            {

                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSOR";
                    break;

            }

            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + computer);

            switch (player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("It'a draw");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You Lost my friend!");

                    }
                    else
                    {
                        Console.WriteLine("Wohoo! You Won");
                    }
                    break;
                case "PAPER":
                      if (computer == "ROCK")
                    {
                        Console.WriteLine("Wohoo! You Won");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("It's a draw");

                    }
                    else
                    {
                        Console.WriteLine("You lost my friend");
                    }
                    break;
                case "SCISSOR":
                     if (computer == "ROCK")
                    {
                        Console.WriteLine("You Lose my friend!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("Wohoo, You Won");

                    }
                    else
                    {
                        Console.WriteLine("It's a draw");
                    }
                    break;

            }


            Console.WriteLine("Would You play again? (Y/N): ");
            answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }

            
        }

        Console.WriteLine("Thanks for playing, have a nice day! :)");

        Console.ReadLine();

        
    }
}

