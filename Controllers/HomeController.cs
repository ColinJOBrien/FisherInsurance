using System;
using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
public class HomeController : Controller

{
    public IActionResult Index()
    {
            //return Ok("This is the index of the HomeController");         
            return View(); 
    }

    public IActionResult Quote()
    {
        Quote HomeQuote = new Quote  {             
            Id = 345,             
            Product = "Life Insurance",
            ExpireDate = DateTime.Now.AddDays(45),             
            Price = 45.00M         
        }; 
        return View(HomeQuote);       
    }
    
}