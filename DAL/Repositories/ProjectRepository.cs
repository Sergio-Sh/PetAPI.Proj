using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using WebAPI.Proj.DAL.Entities;
using WebAPI.Proj.DAL.Context;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.Proj.Common.DTO;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Proj.DAL.Repositories
{
    public class ProjectRepository : BaseRepository
    {
        public ProjectRepository(WebDbContext context, IMapper mapper) : base(context, mapper) 
        { 
        }

        public async Task<ProjectDTO> Create(ProjectDTO projectDto)
        {
            var projectEntity = _mapper.Map<Project>(projectDto);
            projectEntity.CreatedAt = DateTime.Now.ToString();

            await _context.Projects.AddAsync(projectEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProjectDTO>(projectEntity);
        }

        public async Task<ICollection<ProjectDTO>> Read()
        {
            var projects = await _context.Projects.ToListAsync();

            return _mapper.Map<ICollection<ProjectDTO>>(projects);
        }

        public async System.Threading.Tasks.Task Update(ProjectDTO projectDto)
        {
            if (projectDto == null) {
                throw new Exception();
            }

            var projectEntity = _mapper.Map<Project>(projectDto);
            _context.Projects.Update(projectEntity);

            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task Delete(int projectId)
        {
            var projectEntity = await _context.Projects.FirstOrDefaultAsync(p => p.Id == projectId);
            _context.Projects.Remove(projectEntity);

            await _context.SaveChangesAsync();
        }
    }
}
