using System;

namespace RockPaperScissors.Models
{
    public class Game
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }

        public string UserGameChoice { get; set; }
        
        public Game(string player1, string player2, string userGameChoice)
        {
            Player1 = player1;
            Player2 = player2;
            UserGameChoice = userGameChoice;

        }

        public string FindWinner()
        {
            string gameWinner = "";
            if (Player1 == Player2)
            {
            gameWinner = "Try again!";
            }
            else if (Player1 == "rock" && Player2 == "paper" || Player2 == "rock" && Player1 == "scissors" || Player2 == "scissors" && Player1 == "paper")
            {
            gameWinner = "Player 2 wins!";
            }
            else if (Player2 == "rock" && Player1 == "paper" || Player1 == "rock" && Player2 == "scissors" || Player1 == "scissors" && Player2 == "paper")
            {
            gameWinner = "Player 1 wins!";
            }
            return gameWinner;
        }
    }
}   