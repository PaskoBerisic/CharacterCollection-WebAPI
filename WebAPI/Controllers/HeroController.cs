﻿using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using System;

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

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<HeroModel>>> Get()
        {
            var characters = await characterCollectionService.GetAllHeroes();
            return Ok((characters));
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
            var hero = await characterCollectionService.DeleteHero(id);
            return Ok($"Hero with id {hero.Id} deleted");
        }
    }
}