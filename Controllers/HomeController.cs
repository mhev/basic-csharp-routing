using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   
    {
        
        [HttpGet]       
        [Route("")]     
        public string Index()
        {
            return "This is my Index!";
        }
        [HttpGet]
        [Route("/projects")]
        public string projects()
        {
            return "These are my projects";
        }
        [HttpGet]
        [Route("/contact")]
        public string contact()
        {
            return "These are my contacts";
        }
    }
}
