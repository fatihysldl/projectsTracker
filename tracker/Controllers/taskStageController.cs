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

    public class taskStageController : ControllerBase
    {
        private readonly ITaskStageService _taskStage;
        private readonly IMapper _mapper;

        public taskStageController(ITaskStageService taskStage, IMapper mapper)
        {
            _taskStage = taskStage;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult getAllTaskStage()
        {
            var values = _taskStage.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult getTaskStage(taskStage p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<taskStage>(p);
            _taskStage.insert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult deleteTaskStage(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var taskStageId = _taskStage.getById(id);
            _taskStage.delete(taskStageId);
            return Ok();
        }
        [HttpPut]
        public IActionResult putTaskStage(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var taskStageId = _taskStage.getById(id);
            _taskStage.update(taskStageId);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult getTaskStage(int id)
        {
            var values = _taskStage.getById(id);
            return Ok(values);
        }
    }
}
