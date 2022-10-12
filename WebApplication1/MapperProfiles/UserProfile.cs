using AutoMapper;
using AutoMapperExampleApi.Models;
using static AutoMapperExampleApi.Models.UserInfoDto;

namespace AutoMapperExampleApi.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserInfoDto>()
                .ForMember(destination => destination.FullName, operation => operation.MapFrom(source => source.FirstName + " " + source.LastName))
                .ForMember(destination => destination.Status, operation => operation.MapFrom(source => ((UserStatusEnum)source.Status).ToString()));
        }
    }
}
