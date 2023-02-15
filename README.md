# Rock-Paper-Scissors Game in C#

This is a simple console-based implementation of the classic rock-paper-scissors game in C#

## How to Play

    Clone or download the repository to your local machine.
    
    Open the solution in Visual Studio or your preferred IDE.
    
    Build and run the program.
    
    Enter "ROCK", "PAPER", or "SCISSOR" when prompted to make your move.
    
    The computer will randomly choose its own move.
    
    The program will then print the result of the round and ask if you want to play again.
    
    Type "Y" to play again, or any other key to exit the program.

## Game Rules

    Rock beats scissors
    Scissors beats paper
    Paper beats rock
    

## Code Overview

The Main method starts by initializing a Random object and a bool variable playAgain to true. Then it enters a while loop that will continue to run as long as playAgain is true.

Inside the loop, the program prompts the player to enter their move and checks that the input is valid (i.e., "ROCK", "PAPER", or "SCISSOR"). If the input is invalid, the prompt will be repeated until a valid input is provided.

Next, the program generates a random move for the computer and compares it to the player's move to determine the winner of the round. The result is printed to the console.

After the round, the program prompts the player to choose whether to play again. If the player enters "Y", playAgain remains true and the loop will repeat. Otherwise, playAgain is set to false and the program exits the loop.

Finally, the program prints a thank-you message and waits for the user to press a key before terminating. Dependencies

This project was inspired by the classic game Rock Paper Scissors and was created as a fun exercise in C# programming.
