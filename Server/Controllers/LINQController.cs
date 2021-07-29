using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebAPI.Proj.BLL;
using WebAPI.Proj.Common.DTO;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LINQController : ControllerBase
    {
        private LINQ_Serviсe LinqServiсe;
        public LINQController(LINQ_Serviсe serviсe)
        {
            LinqServiсe = serviсe;
        }

        [HttpGet("NumberTasks/{id}")]
        public async Task<ActionResult<ICollection<KeyValuePair<string, int>>>> GetNumberTasks(int id)
        {
            return Ok(await LinqServiсe.GetNumberTasks(id));
        }

        [HttpGet("GetTasks/{id}")]
        public async Task<ActionResult<ICollection<TaskDTO>>> GetTasks(int id)
        {
            return Ok(await LinqServiсe.GetTasks(id));
        }

        [HttpGet("GetFinished21/{id}")]
        public async Task<ActionResult<FinishedTaskDTO>> GetFinished21(int id)
        {
            return Ok(await LinqServiсe.GetFinished21(id));
        }

        [HttpGet("GetTeam_Users")]
        public async Task<ActionResult<ICollection<Team_UsersDTO>>> GetTeam_Users()
        {
            return Ok(await LinqServiсe.GetTeam_Users());
        }

        [HttpGet("GetUser_Tasks")]
        public async Task<ActionResult<ICollection<Users_TaskDTO>>> GetUser_Tasks()
        {
            return Ok(await LinqServiсe.GetUser_Tasks());
        }

    }
}
