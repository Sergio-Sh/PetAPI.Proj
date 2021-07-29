using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Proj.DAL.Entities;
using System.Threading.Tasks;
using WebAPI.Proj.DAL.Repositories;
using WebAPI.Proj.Common.DTO;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private ProjectRepository _projectRepo;
        public ProjectsController(ProjectRepository projectRepository)
        {
            _projectRepo = projectRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<ProjectDTO>>> Get()
        {
            return Ok(await _projectRepo.Read());
        }

        [HttpPost]
        public async Task<ActionResult<ProjectDTO>> Post([FromBody] ProjectDTO projectDto)
        {
            return Ok(await _projectRepo.Create(projectDto));
        }

        [HttpPut]
        public async Task<IActionResult> Put(ProjectDTO projectDto)
        {
            await _projectRepo.Update(projectDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _projectRepo.Delete(id);
            return NoContent();
        }
    }
}
