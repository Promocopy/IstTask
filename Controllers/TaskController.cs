using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace istTask.Controllers
{
    
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        [Route("api")]
        public IActionResult Task(string slack_name, string track)
        {
            var user = new
            {
                slackName = "Promocopy",
                currentDay = DateTime.UtcNow.DayOfWeek,
                utcTime = DateTime.UtcNow.ToString("yyyy-mm-dd:hh-mm-ssZ"),
                track = "Backend",
                github_file_url= "https://github.com/Promocopy/istTask/blob/master/istTask/Controllers/TaskController.cs",
                github_repo_url = "https://github.com/Promocopy/istTask",
                StatusCode = Response.StatusCode


            };
            return Ok(user);
        }
    }
}
