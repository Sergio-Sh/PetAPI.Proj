using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI.Proj.Common.DTO;
using WebAPI.Proj.DAL.Context;
using WebAPI.Proj.DAL.Entities;


namespace WebAPI.Proj.DAL.Repositories
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(WebDbContext context, IMapper mapper) : base(context, mapper) { }


        public async Task<UserDTO> Create(UserDTO projectDto)
        {
            var userEntity = _mapper.Map<User>(projectDto);

            await _context.Users.AddAsync(userEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<UserDTO>(userEntity);
        }

        public async Task<ICollection<UserDTO>> Read()
        {
            var users = await _context.Users.ToListAsync();

            return _mapper.Map<ICollection<UserDTO>>(users);
        }

        public async System.Threading.Tasks.Task Update(UserDTO userDto)
        {
            if (userDto == null) {
                throw new Exception();
            }

            var userEntity = _mapper.Map<User>(userDto);
            _context.Users.Update(userEntity);

            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task Delete(int userId)
        {
            var userEntity = await _context.Users.FirstOrDefaultAsync(p => p.Id == userId);
            _context.Users.Remove(userEntity);

            await _context.SaveChangesAsync();
        }
    }
}
