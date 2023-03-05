using BlazorCar.Server.Authentication;
using BlazorCar.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//using (Coding Droplets, 2022)
namespace BlazorCar.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserAccountService _userAccountService;
        public AccountController(UserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        

        public ActionResult<UserSession> Login([FromBody] LoginRequest loginRequest)
        {
            //creating a new instance of the JwtAuthenticationManager class
            var jwtAuthenticationManager = new JwtAuthenticationManager(_userAccountService);
            //getting the generated token for the user with the username and password specified
            var userSession = jwtAuthenticationManager.GenerateJwtToken(loginRequest.UserName, loginRequest.Password);

            //if the uname or pword was invalid then we will not authorise - if valid we do
            if (userSession is null)
            {
                return Unauthorized();
            }
            else
            {
                return userSession;
            }
        }
    }
}
