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
    public class TeamsController : ControllerBase
    {
        private TeamRepository _teamRepo;
        public TeamsController(TeamRepository teamRepository)
        {
            _teamRepo = teamRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<TeamDTO>>> Get()
        {
            return Ok(await _teamRepo.Read());
        }

        [HttpPost]
        public async Task<ActionResult<TeamDTO>> Post([FromBody] TeamDTO teamDto)
        {
            return Ok(await _teamRepo.Create(teamDto));
        }

        [HttpPut]
        public async Task<IActionResult> Put(TeamDTO teamDto)
        {
            await _teamRepo.Update(teamDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _teamRepo.Delete(id);
            return NoContent();
        }
    }
}
