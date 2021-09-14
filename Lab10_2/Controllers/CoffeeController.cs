using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using Lab10_2.Models;


namespace Lab10_2.Controllers
{
    public class CoffeeController : Controller
    {
        public IActionResult Index()
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop2;Uid=root;Password=abc123");
            List<Product> prod = db.GetAll<Product>().ToList();
            return View(prod);
        }
        public IActionResult Detail(int pr)
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop2;Uid=root;Password=abc123");
            Product prod = db.Get<Product>(pr);
            return View(prod);
        }
    }
}
