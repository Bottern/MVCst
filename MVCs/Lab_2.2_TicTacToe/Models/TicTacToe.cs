using System;
using System.Collections.Generic;
using System.Linq;
//using System.Web;

namespace Lab_2._2_TicTacToe.Models
{
    public class TicTacToe
    {
        public static int InitalizeBoard(List<TileCordinate> tiles)
        {
            int horizontal = 8;
            int vertical = 3;

            for (int i = 0; i < horizontal; i++)
            {
                for (int j = 0; j < vertical; j++)
                {
                    tiles.Add(new TileCordinate { XCordinate = i, YCordinate = j, Sign = ' ' });
                }
            }

            for (int j = 0; j <= 8; j++)
            {
                tiles[j].ID = j;
            }
            return horizontal;
        }
        public static void ResetBoard()
        {
            Board.TileCordinates = new List<TileCordinate>();
            for (int i = 01; i <= 9; i++)
            {
                Board.TileCordinates.Add(new TileCordinate() { ID = i, Sign = char.Parse(i.ToString()), DisableButton = false });
            }
        }
        public static int RandomFreeTiles()
        {
            List<int> freeTiles = (from cordinate in Board.TileCordinates where cordinate.Sign != 'X' && cordinate.Sign != 'O' select cordinate.ID).ToList();
            Random randomNr = new Random();
            int squareId = randomNr.Next(0, freeTiles.Count - 1);
            return freeTiles[squareId];
        }
        public static int ComputersTurn()
        {
            if (Board.TileCordinates[4].Sign == '5')
                return 5;
            return RandomFreeTiles();
        }
        public static string GamePlay(string send)
        {
            ChangeCordinates(int.Parse(send), 'X');
            string message = GameResult('X');
            if (message.Length > 0)
                return message;

            ChangeCordinates(ComputersTurn(), 'O');
            message = GameResult('O');
            if (message.Length > 0)
                return message;

            //message = GameResult('0');
            //if (message.Length > 0)
            //{
            //    return message;
            //}
            return message;
        }
        public static void ChangeCordinates(int id, char sign)
        {
            foreach (TileCordinate t in Board.TileCordinates.Where(t => t.ID == id))
            {
                t.Sign = sign;
            }
        }
        public static bool DiagonalRowWin(char checkWhatSign)
        {
            if (Board.TileCordinates[0].Sign == checkWhatSign && Board.TileCordinates[4].Sign == checkWhatSign && Board.TileCordinates[8].Sign == checkWhatSign)
            {
                return true;
            }
            if (Board.TileCordinates[2].Sign == checkWhatSign && Board.TileCordinates[4].Sign == checkWhatSign &&
                Board.TileCordinates[6].Sign == checkWhatSign)
            {
                return true;
            }
            return false;
        }
        public static bool VerticalRowWin(char checkWhatSign)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Board.TileCordinates[i].Sign == checkWhatSign && Board.TileCordinates[i + 3].Sign == checkWhatSign &&
                    Board.TileCordinates[i + 6].Sign == checkWhatSign)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool HorizontalWin(char checkWhatSign)
        {
            for (int i = 0; i < 9; i += 3)
            {
                if (Board.TileCordinates[i].Sign == checkWhatSign && Board.TileCordinates[i + 1].Sign == checkWhatSign &&
                    Board.TileCordinates[i + 2].Sign == checkWhatSign)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool GameEndInTie()
        {
            int counter = Board.TileCordinates.Count(cordinate => cordinate.Sign == 'O' || cordinate.Sign == 'X');
            if (counter == 9)
                return true;
            return false;
        }
        public static string GameResult(char checkResult)
        {
            if (DiagonalRowWin(checkResult) || VerticalRowWin(checkResult) || HorizontalWin(checkResult))
            {
                if (checkResult == 'X')
                {
                    ResetBoard();
                    return "You are the winner. How does that make you feel";
                }
                if (checkResult == 'O')
                {
                    ResetBoard();
                    return "You lost, too bad. But in this case impressive";
                }
            }
            if (GameEndInTie())
            {
                ResetBoard();
                return "The game ended in a tie. Do it right, do it again";
            }
            return String.Empty;
        }
    }
}