using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RickAndMorty.Data;
using RickAndMorty.DTOs.Display;
using RickAndMorty.Models;
using System;

namespace RickAndMorty.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RickAndMortyController : ControllerBase
    {
        private readonly RickAndMortyDbContext _context;
        private readonly ILogger<RickAndMortyController> _logger;
        private readonly IMapper _mapper;

        public RickAndMortyController(RickAndMortyDbContext context, ILogger<RickAndMortyController> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("/api/ListEpisodes")]
        public async Task<ActionResult<IEnumerable<DisplayEpisodeDto>>> ListEpisodes()
        {
            var episodes = await _context.episodes.Include(e=>e.characters)
                .ToListAsync();
            
            var episodesDto = _mapper.Map<IEnumerable<DisplayEpisodeDto>>(episodes);

            return Ok(episodesDto);
        }

        [HttpGet("/api/ListCharacters")]
        public async Task<ActionResult<IEnumerable<DisplayCharacterDto>>> ListCharacters()
        {
            var characters = await _context.characters.Include(e => e.episode)
                .Include(e => e.origin)
                .Include(e => e.location)
                .ToListAsync();

            var charactersDto = _mapper.Map<IEnumerable<DisplayCharacterDto>>(characters);

            return Ok(charactersDto);
        }

        [HttpGet("/api/ListLocations")]
        public async Task<ActionResult<IEnumerable<Location>>> ListLocations()
        {
            var locations = await _context.locations.ToListAsync();            

            return Ok(locations);
        }

        [HttpPost("/api/characters/save")]
        public async Task<IActionResult> SaveCharacters([FromBody] List<Character> characters)
        {
            try
            {
                foreach (var character in characters)
                {
                    var entity = new Character
                    {
                        id = character.id,
                        name = character.name,
                        status = character.status,
                        species = character.species,
                        type = character.type,
                        gender = character.gender,
                        origin = character.origin,
                        location = character.location,
                        episode = character.episode,
                        image = character.image

                    };
                    _context.characters.Add(entity);
                }

                await _context.SaveChangesAsync();

                return Ok("Characters have been saved!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error at saving characters");
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("/api/episode/save")]
        public async Task<IActionResult> SaveEpisodes([FromBody] List<Episode> episodes)
        {
            try
            {
                foreach (var episode in episodes)
                {
                    var entity = new Episode
                    {
                        id = episode.id,
                        name =episode.name,
                        air_date = episode.air_date,
                        episode = episode.episode,
                        characters = episode.characters,

                    };
                    _context.episodes.Add(entity);
                }

                await _context.SaveChangesAsync();

                return Ok("Episodes have been saved!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error at saving episodes");
                return BadRequest(ex.Message);
            }
        }
    }
}
