using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebAPI.Proj.Common.DTO;
using WebAPI.Proj.DAL.Context;
using WebAPI.Proj.DAL.Entities;

namespace WebAPI.Proj.DAL.Repositories
{
    public class TaskRepository : BaseRepository
    {
        public TaskRepository(WebDbContext context, IMapper mapper) : base(context, mapper) { }


        public async Task<TaskDTO> Create(TaskDTO taskDto)
        {
            var taskEntity = _mapper.Map<Entities.Task>(taskDto);
            taskEntity.CreatedAt = DateTime.Now;

            await _context.Tasks.AddAsync(taskEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<TaskDTO>(taskEntity);
        }

        public async Task<ICollection<TaskDTO>> Read()
        {
            var tasks = await _context.Tasks.ToListAsync();

            return _mapper.Map<ICollection<TaskDTO>>(tasks);
        }

        public async System.Threading.Tasks.Task Update(TaskDTO taskDto)
        {
            if (taskDto == null) {
                throw new Exception();
            }

            var taskEntity = _mapper.Map<Entities.Task>(taskDto);
            _context.Tasks.Update(taskEntity);

            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task Delete(int taskId)
        {
            var taskEntity = await _context.Tasks.FirstOrDefaultAsync(p => p.Id == taskId);
            _context.Tasks.Remove(taskEntity);

            await _context.SaveChangesAsync();
        }
    }
}
