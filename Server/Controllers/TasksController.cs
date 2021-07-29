using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Proj.DAL.Entities;
using WebAPI.Proj.Common.DTO;
using WebAPI.Proj.DAL.Repositories;
using System.Threading.Tasks;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private TaskRepository _taskRepo;
        public TasksController(TaskRepository taskRepository)
        {
            _taskRepo = taskRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<TaskDTO>>> Get()
        {
            return Ok(await _taskRepo.Read());
        }

        [HttpPost]
        public async Task<ActionResult<TaskDTO>> Post([FromBody] TaskDTO taskDto)
        {
            return Ok(await _taskRepo.Create(taskDto));
        }

        [HttpPut]
        public async Task<IActionResult> Put(TaskDTO taskDto)
        {
            await _taskRepo.Update(taskDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _taskRepo.Delete(id);
            return NoContent();
        }
    }
}
