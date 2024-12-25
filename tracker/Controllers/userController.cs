using AutoMapper;
using businessLayer.abstracts;
using dtoLayer.appUserDtos;
using entityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public userController(IUserService userService, IMapper mapper, UserManager<AppUser> userManager)
        {
            _userService = userService;
            _mapper = mapper;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult getAllUsers()
        {
            var values = _userService.getAll();
            return Ok(values);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser(addUserDto p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = _mapper.Map<AppUser>(p);
            var result = await _userManager.CreateAsync(user, "DefaultPassword123");

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Manager"); // Varsayılan olarak Manager rolü atıyoruz
                return Ok("User registered successfully.");
            }

            return BadRequest(result.Errors);
        }
        [HttpPost("login")]
        public async Task<IActionResult> LoginUser(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null && await _userManager.CheckPasswordAsync(user, password))
            {
                return Ok("Login successful.");
            }
            return Unauthorized("Invalid login attempt.");
        }
        [HttpPost]
        public IActionResult postProject(addUserDto p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<AppUser>(p);
            _userService.insert(values);
            return Ok();
        }
    }
}
