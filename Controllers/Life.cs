using Microsoft.AspNetCore.Mvc;

public class LifeController : Controller

{
    public IActionResult Index()
    {
        return Ok("This is the index of the AutoController");
    }

    public IActionResult Quote() 
    {
        return Ok("This is auto/quote");
    }
    
}