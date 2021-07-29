using AutoMapper;
using WebAPI.Proj.Common.DTO;
using WebAPI.Proj.DAL.Entities;

namespace BLL.MappingProfiles
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<Task, TaskDTO>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(t => t.Id))
                .ForMember(dto => dto.ProjectId, opt => opt.MapFrom(t => t.ProjectId))
                .ForMember(dto => dto.PerformerId, opt => opt.MapFrom(t => t.PerformerId))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(t => t.Name))
                .ForMember(dto => dto.Description, opt => opt.MapFrom(t => t.Description))
                .ForMember(dto => dto.State, opt => opt.MapFrom(t => t.State))
                .ForMember(dto => dto.CreatedAt, opt => opt.MapFrom(t => t.CreatedAt))
                .ForMember(dto => dto.FinishedAt, opt => opt.MapFrom(t => t.FinishedAt));

            CreateMap<TaskDTO, Task>()
                .ForMember(t => t.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(t => t.ProjectId, opt => opt.MapFrom(dto => dto.ProjectId))
                .ForMember(t => t.PerformerId, opt => opt.MapFrom(dto => dto.PerformerId))
                .ForMember(t => t.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(t => t.Description, opt => opt.MapFrom(dto => dto.Description))
                .ForMember(t => t.State, opt => opt.MapFrom(dto => dto.State))
                .ForMember(t => t.CreatedAt, opt => opt.MapFrom(dto => dto.CreatedAt))
                .ForMember(t => t.FinishedAt, opt => opt.MapFrom(dto => dto.FinishedAt));
        }
    }
}
