using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]
    public class HeroController : Controller
    {
        private readonly ICharacterCollectionService characterCollectionService;
        private readonly IMapper mapper;
        public HeroController(ICharacterCollectionService characterCollectionService, IMapper mapper)
        {
            this.characterCollectionService = characterCollectionService;
            this.mapper = mapper;
        }

        [HttpGet()] // Changed to Entity from Model
        public async Task<ActionResult<IEnumerable<Hero>>> Get()
        {
            var heroes = await characterCollectionService.GetAllHeroes();
            return Ok(mapper.Map<List<Hero>>(heroes));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<HeroModel>>> GetById(int id)
        {
            var hero = await characterCollectionService.GetHeroById(id);
            if (hero is null)
            {
                return NotFound($"Hero with id {id} not found.");
            }
            var heroModel = mapper.Map<HeroModel>(hero);
            return Ok(heroModel);
        }

        [HttpPost]
        public async Task<ActionResult<HeroModel>> Add([FromBody] HeroModel heroModel)
        {
            var hero = mapper.Map<Hero>(heroModel);
            var heroAdded = await characterCollectionService.AddHero(hero);

            return CreatedAtAction(nameof(GetById), new { heroAdded.Id }, heroAdded);
        }

        [HttpPut]
        public async Task<ActionResult<HeroModel>> Update([FromBody] Hero hero)
        {
            await characterCollectionService.UpdateHero(hero);
            return CreatedAtAction(nameof(GetById), new { hero.Id }, hero);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<HeroModel>> Delete(int id)
        {
            await characterCollectionService.DeleteHeroById(id);
            return Ok($"Hero with id {id} deleted");
        }
    }
}
