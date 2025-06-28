using AutoMapper;
using GamePlatformService.Dtos;
using GamePlatformService.Models;

namespace GamePlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target
            CreateMap<Platform, PlatformReadDtos>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
