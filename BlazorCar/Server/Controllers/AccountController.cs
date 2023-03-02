﻿using BlazorCar.Server.Authentication;
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
        //[Authorise(Roles = "Administrator")] to make something admin only

        public ActionResult<UserSession> Login([FromBody] LoginRequest loginRequest)
        {
            var jwtAuthenticationManager = new JwtAuthenticationManager(_userAccountService);
            var userSession = jwtAuthenticationManager.GenerateJwtToken(loginRequest.UserName, loginRequest.Password);

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
