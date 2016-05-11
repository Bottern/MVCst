using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_2._2_TicTacToe.Models;

namespace Lab_2._2_TicTacToe.Controllers
{
    public class TicTacToeController : Controller
    {
        // GET: TicTacToe
        public ActionResult Index()
        {
            TicTacToe.ResetBoard();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string send)
        {
            try
            {
                if (send == "Reset Game")
                {
                    TicTacToe.ResetBoard();
                }
                else
                {
                    ViewBag.Message = TicTacToe.GamePlay(send);
                }
                return View();
            }
            catch (Exception e)
            {
                ViewBag.Message = "Choose an empty tile";
                return View();
            }
        }
    }
}