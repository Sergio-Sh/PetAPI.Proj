using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Proj.DAL.Entities;
using System.Threading.Tasks;
using WebAPI.Proj.DAL.Repositories;
using WebAPI.Proj.Common.DTO;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UserRepository _userRepo;
        public UsersController(UserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<UserDTO>>> Get()
        {
            return Ok(await _userRepo.Read());
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post([FromBody] UserDTO userDto)
        {
            return Ok(await _userRepo.Create(userDto));
        }

        [HttpPut]
        public async Task<IActionResult> Put(UserDTO usertDto)
        {
            await _userRepo.Update(usertDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userRepo.Delete(id);
            return NoContent();
        }
    }
}
