using System;
using System.Linq;
using System.Collections.Generic;
using WebAPI.Proj.Common.DTO;
using WebAPI.Proj.DAL.Repositories;
using WebAPI.Proj.DAL.Entities;
using WebAPI.Proj.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AutoMapper;

namespace WebAPI.Proj.BLL
{
    public class LINQ_Serviсe : BaseService
    {
        public List<Project> _projects { get; set; }
        public List<DAL.Entities.Task> _tasks { get; set; }
        public List<Team> _teaams { get; set; }
        public List<User> _users { get; set; }

        public LINQ_Serviсe(WebDbContext context, IMapper mapper) : base (context, mapper)
        {
            _projects = _context.Projects.ToList();
            _tasks = _context.Tasks.ToList();
            _teaams = _context.Teams.ToList();
            _users = _context.Users.ToList();
        }

        public async Task<Dictionary<string, int>> GetNumberTasks(int id)
        {
            var sample = await System.Threading.Tasks.Task.Run(() =>
                    from task in _tasks
                    group task by task.ProjectId into taskGroup
                    join proj in _projects on taskGroup.Key equals proj.Id
                    select new
                    {
                        ProjectId = taskGroup.Key,
                        NumbTasks = taskGroup.Count(x => x.PerformerId == id)
                    });

             return sample.ToDictionary(x => x.ProjectId.ToString(), x => x.NumbTasks);
        }

        public async Task<List<TaskDTO>> GetTasks(int id)
        {
            var sample = await System.Threading.Tasks.Task.Run(() => _tasks
                .Where(task => task.PerformerId == id && task.Name.Length < 45)
                .Select(task => _mapper.Map<TaskDTO>(task)));

            return sample.ToList();
        }

        public async Task<List<FinishedTaskDTO>> GetFinished21(int id)
        {
            var sample = await System.Threading.Tasks.Task.Run(() => _tasks
                .Where(task => task.PerformerId == id && task.FinishedAt.Year == 2021)
                .Select(task => new FinishedTaskDTO { Id = task.Id, Name = task.Name }));

            return sample.ToList();
        }

        public async Task<List<Team_UsersDTO>> GetTeam_Users()
        {
            var sample = await System.Threading.Tasks.Task.Run(() => _users
                .OrderByDescending(u => u.RegisteredAt)
                .GroupBy(user => user.TeamId)
                .Where(group => group.All(user => user.BirthDay.Year < 2011))
                .Join(_teaams,
                users => users.Key,
                team => team.Id,
                (users, team) => new Team_UsersDTO
                {
                    Id = team.Id,
                    TimeName = team.Name,
                    Users = users.Select(u =>u.FirstName).ToList()
                }));

            return sample.ToList();
        }

        public async Task<List<Users_TaskDTO>> GetUser_Tasks()
        {
            var sample = await System.Threading.Tasks.Task.Run(() =>
                    from user in _users
                    orderby user.FirstName
                    let tasks = _tasks.Where(t => t.PerformerId == user.Id).OrderByDescending(t => t.Name)
                    select new Users_TaskDTO
                    {
                        User = _mapper.Map<UserDTO>(user),
                        Tasks = _mapper.Map<ICollection<TaskDTO>>(tasks).ToList()
                    });

            return sample.ToList();
        }
    }
}
