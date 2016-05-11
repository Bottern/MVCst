using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_2._2_TicTacToe.Models
{
    public class TileCordinate
    {
        public int ID { get; set; }
        public char Sign { get; set; }
        public int XCordinate { get; set; }
        public int YCordinate { get; set; }
        public bool DisableButton { get; set; }
    }
}