using AutoMapper;
using WebAPI.Proj.Common.DTO;
using WebAPI.Proj.DAL.Entities;


namespace BLL.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(u => u.Id))
                .ForMember(dto => dto.TeamId, opt => opt.MapFrom(u => u.TeamId))
                .ForMember(dto => dto.FirstName, opt => opt.MapFrom(u => u.FirstName))
                .ForMember(dto => dto.LastName, opt => opt.MapFrom(u => u.LastName))
                .ForMember(dto => dto.Email, opt => opt.MapFrom(u => u.Email))
                .ForMember(dto => dto.RegisteredAt, opt => opt.MapFrom(u => u.RegisteredAt))
                .ForMember(dto => dto.BirthDay, opt => opt.MapFrom(u => u.BirthDay));

            CreateMap<UserDTO, User>()
                .ForMember(u => u.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(u => u.TeamId, opt => opt.MapFrom(dto => dto.TeamId))
                .ForMember(u => u.FirstName, opt => opt.MapFrom(dto => dto.FirstName))
                .ForMember(u => u.LastName, opt => opt.MapFrom(dto => dto.LastName))
                .ForMember(u => u.Email, opt => opt.MapFrom(dto => dto.Email))
                .ForMember(u => u.RegisteredAt, opt => opt.MapFrom(dto => dto.RegisteredAt))
                .ForMember(u => u.BirthDay, opt => opt.MapFrom(dto => dto.BirthDay));
        }
    }
}
