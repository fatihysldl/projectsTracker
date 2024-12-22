using AutoMapper;
using businessLayer.abstracts;
using entityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class projectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;

        public projectsController(IProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult getAllProject()
        {
            var values = _projectService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult postProject(project p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<project>(p);
            _projectService.insert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult deleteProject(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var projectId = _projectService.getById(id);
            _projectService.delete(projectId);
            return Ok();
        }
        [HttpPut]
        public IActionResult putProject(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var projectId = _projectService.getById(id);
            _projectService.update(projectId);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult getProject(int id)
        {
            var values = _projectService.getById(id);
            return Ok(values);
        }
    }
}
