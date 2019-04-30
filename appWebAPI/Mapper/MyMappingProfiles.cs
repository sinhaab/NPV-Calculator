using System;
using AutoMapper;

namespace Core.Mapper
{
    public class MyMappingProfiles : Profile
    {
        public MyMappingProfiles()
        {
          /*  CreateMap<UserEntity, User>()
              .ForMember(dest => dest.Gender, source => source.MapFrom(src => src.Gender.ToString()))
              .ForMember(dest => dest.FirstName, source => source.MapFrom(src => src.FirstName.ToUpper()))
              .ForMember(dest => dest.LastName, source => source.MapFrom(src => src.LastName.ToUpper()))
              .ForMember(dest => dest.SIN, source => source.MapFrom(src => src.Id)); */
        }
    }
}
