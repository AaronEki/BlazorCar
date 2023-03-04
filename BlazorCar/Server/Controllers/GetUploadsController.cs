using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCar.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetUploadsController : ControllerBase
    {
        //used when getting the path for the uploads folder
        private readonly IWebHostEnvironment _env;

        public GetUploadsController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpGet]
        
        //creating a method to get the files in the uploads directory!
        public IActionResult GetUploads()
        {
            //try catch to allow us to catch unhandled exceptions
            try
            {
                //getting a list of files from the uploads folder
                //the path is calculated by the ContentRootPath - which will get the path for the server and appending uploads to this
                //this gives us the full path of the uploads directory without hardcoding it
                var files = Directory.GetFiles(Path.Combine(_env.ContentRootPath, "uploads"));
                //select the filenames from the list of files
                var filenames = files.Select(f => Path.GetFileName(f));
                //return the list of filenames
                return Ok(filenames);
            }
            catch
            {
                //error message if we cannot complete the above try block
                return BadRequest("Error getting files from /uploads");
            }
            
            
        }

    }
}
