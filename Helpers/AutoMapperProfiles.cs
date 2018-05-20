using AutoMapper;
using WaifuDatingApp.API.DTOs;
using WaifuDatingApp.API.Models;

namespace WaifuDatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForDetailedDTO>();
        }
    }
}