//lerissa lazar
//10-27-22
//restaurant picker
//the user will input a category and the computer will output a restaurant to try
//peer review: Andrew Nilsson - really basic restaurant names. Maybe try and make a random input to output a random restaurant from any category
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarL_MiniChRestrauntPicker.Controllers
{
    [Route("[controller]")]
    public class RestPicker : Controller
    {
        [HttpGet]
        [Route("Picker/{input}")]
        public string Restaurant(string input)
        {
            Random rnd = new Random();
            string[] breakfast = {"IHOP", "Perkos", "Dennys", "Dunkin Donuts", "Huckleberrys", "Black Bear Diner", "Omelet House",
                    "Waffle House", "Bryn Mawr Breakfast Club", "Flying Biscuit Cafe"};
            string[] lunch = {"Mountain Mikes", "Chipotle", "Commonwealth", "Mcdonalds", "In-N-Out", "Burger King", "Jack N the Box",
                    "Panera bread", "Subway", "Chick Fil a"};
            string[] dinner = {"WildFire", "Redwood Cafe", "Raw Garden", "Longhorn Steakhouse", "Skewers Kabob House", "Ramen 101",
                    "Memos Cocina", "Texas RoadHouse", "Outback Steakhouse", "BJs"};

            int i = rnd.Next(breakfast.Length);
            if (input == "breakfast")
            {
                return breakfast[i];
            }
            if (input == "lunch")
            {
                return lunch[i];
            }
            if (input == "dinner")
            {
                return dinner[i];
            }
            return "error";
        }
    }
}