using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Proj.DAL.Context;

namespace WebAPI.Proj.BLL
{
    public abstract class BaseService
    {
        private protected readonly WebDbContext _context;
        private protected readonly IMapper _mapper;

        public BaseService(WebDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
