using E_Commerce_Generico.Models.DatabaseModels;
using E_Commerce_Generico.Models.LoginModels;
using E_Commerce_Generico.Services.UserServices;
using E_Commerce_Generico.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace E_Commerce_Generico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUnitOfWork _context;
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        public LoginController(IConfiguration configuration, IUserService userService, IUnitOfWork context)
        {
            _context = context;
            _configuration = configuration;
            _userService = userService;
        }
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserLogin request)
        {
            /*var user = _context.UserRepository.FindByEmail(request.Mail);
            if (user == null) return BadRequest("User not found.");

            string token = CreateToken(user);*/

            return Ok(/*token*/);
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                /*new Claim(ClaimTypes.NameIdentifier, user.userName),
                new Claim(ClaimTypes.Email, user.mail.ToString()),
                new Claim(ClaimTypes.Name, user.fullName),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim(ClaimTypes.Sid, user.UserID.ToString())*/
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(23),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
