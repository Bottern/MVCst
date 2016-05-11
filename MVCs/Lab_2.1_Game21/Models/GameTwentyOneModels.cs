using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_2._1_Game21.Models
{
    public class GameTwentyOneModels
    {
        public static int CurrentNumber { get; set; }
        //public int UpDatedNumber { get; set; }
        public static int RandomNumber()
        {
            Random randomNumber = new Random();
            return randomNumber.Next()%2 == 0 ? 1 : 2;
        }
        public static void SetStartingPlayer()
        {
            if (RandomNumber() == 1)
                CurrentNumber = RandomNumber();
        }
        public static void ComputersTurn()
        {
            CurrentNumber += RandomNumber();
        }
        public static string IsTheGameOver(string turn)
        {
            if (CurrentNumber >= 21)
            {
                if (turn == "player")
                    return "You Wong! Congratulations";
                return "The computer won. Better luck next time";
            }
            return string.Empty;
        }
        public static string GamePlay()
        {
            string playersTurn = GameTwentyOneModels.IsTheGameOver("player");
            if (playersTurn.Length > 0)
            {
                CurrentNumber = 0;
                return playersTurn;
            }
            GameTwentyOneModels.ComputersTurn();
            string computersTurn = GameTwentyOneModels.IsTheGameOver("computer");
            if (computersTurn.Length > 0)
            {
                CurrentNumber = 0;
                return computersTurn;
            }
            return string.Empty;
        }
    }
}