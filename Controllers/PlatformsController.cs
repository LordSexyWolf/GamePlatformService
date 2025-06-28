using AutoMapper;
using GamePlatformService.Data;
using GamePlatformService.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GamePlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        private readonly IPlatformRepo _repository;
        private readonly IMapper _mapper;

        public PlatformsController(IPlatformRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDtos>> GetPlatforms()
        {
            Console.WriteLine("---> Getting Platforms...");
            var platformItems = _repository.GetAllPlatforms();

            return Ok(_mapper.Map<IEnumerable<PlatformReadDtos>> (platformItems));
        }
    }
}
