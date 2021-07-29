using AutoMapper;
using WebAPI.Proj.Common.DTO;
using WebAPI.Proj.DAL.Entities;


namespace BLL.MappingProfiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, TeamDTO>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(t => t.Id))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(t => t.Name))
                .ForMember(dto => dto.CreatedAt, opt => opt.MapFrom(t => t.CreatedAt));

            CreateMap<TeamDTO, Team>()
                .ForMember(t => t.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(t => t.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(t => t.CreatedAt, opt => opt.MapFrom(dto => dto.CreatedAt));
        }
    }
}
