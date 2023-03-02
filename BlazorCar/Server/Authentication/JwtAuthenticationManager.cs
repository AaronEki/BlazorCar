using BlazorCar.Shared;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BlazorCar.Server.Authentication
{
    //authentication method (Coding Droplets, 2022)
    public class JwtAuthenticationManager
    {
        public const string JWT_SECURITY_KEY = "bsaYD3nasjk7SDBAHs2b7268sbaKdaypVhuAjkdSbajiVbjdaBVHPIvhBJHvy92";
        private const int JWT_TOKEN_VALIDIDTY_MINS = 30;

        private UserAccountService _userAccountService;

        public JwtAuthenticationManager(UserAccountService userAccountService)
        {
            _userAccountService = userAccountService;   
        }

        public UserSession? GenerateJwtToken(string userName, string password)
        {
            // if the user supplied username or password is null then we return a null value
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            //user creds validation
            var userAccount = _userAccountService.GetUserAccountByUserName(userName);

            if (userAccount == null || userAccount.Password != password) {
                return null;
            }

            //if the user creds are valid - we can generate our JWT token!
            var tokenExpiryTimeStamp = DateTime.Now.AddMinutes(JWT_TOKEN_VALIDIDTY_MINS);
            var tokenKey = Encoding.ASCII.GetBytes(JWT_SECURITY_KEY);

            var claimsIdentity = new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.Name, userAccount.UserName),
                new Claim(ClaimTypes.Role, userAccount.Role),
            });

            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature
                );

            var securityTokenDescriptor = new SecurityTokenDescriptor { 
                Subject = claimsIdentity,
                Expires = tokenExpiryTimeStamp,
                SigningCredentials = signingCredentials            
            };

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            var token = jwtSecurityTokenHandler.WriteToken(securityToken);

            //create a new user session object and return it as a response of this method
            var userSession = new UserSession { 
                UserName = userAccount.UserName,
                Role = userAccount.Role,
                Token = token,
                ExpiresIn = ((int)tokenExpiryTimeStamp.Subtract(DateTime.Now).TotalSeconds)
            };
            return userSession;
        }

    }
}
