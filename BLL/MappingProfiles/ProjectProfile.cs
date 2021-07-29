using AutoMapper;
using WebAPI.Proj.Common.DTO;
using WebAPI.Proj.DAL.Entities;

namespace BLL.MappingProfiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<Project, ProjectDTO>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(p => p.Id))
                .ForMember(dto => dto.AuthorId, opt => opt.MapFrom(p => p.AuthorId))
                .ForMember(dto => dto.TeamId, opt => opt.MapFrom(p => p.TeamId))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(p => p.Name))
                .ForMember(dto => dto.Description, opt => opt.MapFrom(p => p.Description))
                .ForMember(dto => dto.Deadline, opt => opt.MapFrom(p => p.Deadline))
                .ForMember(dto => dto.CreatedAt, opt => opt.MapFrom(p => p.CreatedAt));

            CreateMap<ProjectDTO, Project>()
                .ForMember(p => p.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(p => p.AuthorId, opt => opt.MapFrom(dto => dto.AuthorId))
                .ForMember(p => p.TeamId, opt => opt.MapFrom(dto => dto.TeamId))
                .ForMember(p => p.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(p => p.Description, opt => opt.MapFrom(dto => dto.Description))
                .ForMember(p => p.Deadline, opt => opt.MapFrom(dto => dto.Deadline))
                .ForMember(p => p.CreatedAt, opt => opt.MapFrom(dto => dto.CreatedAt));
        }
    }
}
