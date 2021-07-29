using AutoMapper;
using WebAPI.Proj.DAL.Context;

namespace WebAPI.Proj.DAL.Repositories
{
    public abstract class BaseRepository
    {
        private protected readonly WebDbContext _context;
        private protected readonly IMapper _mapper;

        public BaseRepository (WebDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
