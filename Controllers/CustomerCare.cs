using Microsoft.AspNetCore.Mvc;

public class CustomerCareController : Controller

{
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }
    [Route("CustomerCare/Claims")] 
    public IActionResult quote() 
    {
        return Ok("This is customercare/claims");
    }
    
}