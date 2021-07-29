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
    public class TeamRepository : BaseRepository
    {
        public TeamRepository(WebDbContext context, IMapper mapper) : base(context, mapper) { }


        public async Task<TeamDTO> Create(TeamDTO teamDto)
        {
            var teamEntity = _mapper.Map<Team>(teamDto);
            teamEntity.CreatedAt = DateTime.Now;

            await _context.Teams.AddAsync(teamEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<TeamDTO>(teamEntity);
        }

        public async Task<ICollection<TeamDTO>> Read()
        {
            var teams = await _context.Teams.ToListAsync();

            return _mapper.Map<ICollection<TeamDTO>>(teams);
        }

        public async System.Threading.Tasks.Task Update(TeamDTO TeamDto)
        {
            if (TeamDto == null) {
                throw new Exception();
            }

            var teamEntity = _mapper.Map<Team>(TeamDto);
            _context.Teams.Update(teamEntity);

            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task Delete(int teamId)
        {
            var teamEntity = await _context.Teams.FirstOrDefaultAsync(p => p.Id == teamId);
            _context.Teams.Remove(teamEntity);

            await _context.SaveChangesAsync();
        }
    }
}
