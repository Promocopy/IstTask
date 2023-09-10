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
                slack_name = slack_name,
                current_Day = DateTime.UtcNow.DayOfWeek.ToString(),  
                utc_time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                track = track.ToLower(),
                github_file_url= "https://github.com/Promocopy/istTask/blob/master/istTask/Controllers/TaskController.cs",
                github_repo_url = "https://github.com/Promocopy/istTask",
                status_code = Response.StatusCode


            };
            return Ok(user);

            //{ "slackName":"Promocopy",
            //"currentDay":0,
            //"utcTime":"2023-24-10:07-24-44Z",
            //"track":"Backend",
            //"github_file_url":"https://github.com/Promocopy/istTask/blob/master/istTask/Controllers/TaskController.cs",

            //"github_repo_url":"https://github.com/Promocopy/istTask",

            //"statusCode":200}




        }
    }
}
