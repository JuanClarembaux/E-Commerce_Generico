using E_Commerce_Generico.Models.DatabaseModels;
using E_Commerce_Generico.Models.RegisterModels;
using E_Commerce_Generico.Services.UserServices;
using E_Commerce_Generico.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Generico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IUnitOfWork _context;
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        public RegisterController(IConfiguration configuration, IUserService userService, IUnitOfWork context)
        {
            _context = context;
            _configuration = configuration;
            _userService = userService;
        }
        [HttpPost("register")]
        public async Task<ActionResult<UserRegister>> Register(UserRegister request)
        {
            /*var userValidation = _context.UserRepository.FindByEmail(request.mail);

            if (userValidation != null) return BadRequest("El usuario ya existe");

            User user = new User();
            user.fullName = request.fullName;
            user.userName = request.userName;
            user.mail = request.mail;
            user.password = request.password;
            _context.UserRepository.Add(user);
            _context.Save();*/

            return Ok(/*user*/);
        }
    }
}
