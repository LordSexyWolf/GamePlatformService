using AutoMapper;
using GamePlatformService.Data;
using GamePlatformService.Dtos;
using GamePlatformService.Models;
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
        [HttpGet("{id}", Name = "GetPlatformById")]
        public ActionResult<PlatformReadDtos> GetPlatformById(int id)
        {
            var platformItems = _repository.GetPlatformById(id);

            if(platformItems != null)
            {
                return Ok(_mapper.Map<PlatformReadDtos>(platformItems));
            }

            return NotFound();
        }
        [HttpPost]
        public ActionResult<PlatformReadDtos> CreatePlatform(PlatformCreateDto platformCreateDto)
        {
            var platformModel = _mapper.Map<Platform>(platformCreateDto);
            _repository.CreatePlatform(platformModel);
            _repository.SaveChanges();

            var platformReadDto = _mapper.Map<PlatformReadDtos>(platformModel);

            return CreatedAtRoute(nameof(GetPlatformById), new { Id = platformReadDto.Id }, platformReadDto);
        }
    }
}
