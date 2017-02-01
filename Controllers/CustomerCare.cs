using Microsoft.AspNetCore.Mvc;
 
public class CustomerCareController : Controller

{
    [Route("customer")]
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }
    [Route("customer/claims")] 
    public IActionResult Quote() 
    {
        return Ok("This is customer/claims");
    }
    [Route("customer/fileclaim")]
        public IActionResult NewClaim() 
    {
        return Ok("This is customer/fileclaim");
    }
    
    [Route("customer/claimstatus")]
        public IActionResult ClaimHistory() 
    {
        return Ok("This is claim/claimstatus");
    }

}