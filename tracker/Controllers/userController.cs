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
        
        public userController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
            
        }
        [HttpGet]
        public IActionResult getAllUsers()
        {
            var values = _userService.getAll();
            return Ok(values);
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
