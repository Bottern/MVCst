using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_2._1_Game21.Models;

namespace Lab_2._1_Game21.Controllers
{
    public class GameTwentyOneController : Controller
    {
        // GET: GameTwentyOne
        public ActionResult Play()
        {
            ViewBag.result = string.Empty;
            ViewBag.choice = 0;
            GameTwentyOneModels.CurrentNumber = 0;
            GameTwentyOneModels.SetStartingPlayer();
            return View();
        }

        [HttpPost]
        public ActionResult Play(string buttonValue)
        {
            int choice = int.Parse(Request["choice"]);
            GameTwentyOneModels.CurrentNumber += choice;
            ViewBag.result = GameTwentyOneModels.GamePlay();
            return View();
        }
    }
}