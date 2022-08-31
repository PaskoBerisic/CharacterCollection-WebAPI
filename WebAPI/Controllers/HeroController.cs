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
            var character = await characterCollectionService.GetHeroById(id);
           // var heroModel = mapper.Map<List<HeroModel>>(character);
            return Ok(character);
        }

        [HttpPost]
        public async Task<ActionResult<HeroModel>> Add([FromBody] HeroModel heroModel)
        {
            var character = mapper.Map<Hero>(heroModel);
            var characterAdded = await characterCollectionService.AddHero(character);

            return CreatedAtAction(nameof(GetById), new { characterAdded.Id }, characterAdded);
        }

        [HttpPut]
        public async Task<ActionResult<HeroModel>> Update([FromBody] Hero hero)
        {
            await characterCollectionService.UpdateHero(hero);
            return CreatedAtAction(nameof(GetById), new { hero.Id }, hero);
        }

        [HttpDelete]
        public async Task<ActionResult<HeroModel>> Delete(int id)
        {
            await characterCollectionService.DeleteHero(id);
            return Ok($"Hero with id {id} deleted");
        }
    }
}
