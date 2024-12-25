using AutoMapper;
using businessLayer.abstracts;
using dtoLayer.companyUserDtos;
using entityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class companyUserController : ControllerBase
    {
        private readonly ICompanyUserService _companyUserService;
        private readonly IMapper _mapper;

        public companyUserController(ICompanyUserService companyUserService, IMapper mapper)
        {
            _companyUserService = companyUserService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult getAllCompanyUsers()
        {
            var values = _companyUserService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult postCompanyUsers(addCompanyUserDto p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<companyUser>(p);
            _companyUserService.insert(values);
            return Ok();
        }
    }
}
