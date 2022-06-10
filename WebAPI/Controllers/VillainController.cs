using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class VillainController : Controller
    {
        private readonly ICharacterCollectionService characterCollectionService;
        private readonly IMapper mapper;
        public VillainController(ICharacterCollectionService characterCollectionService, IMapper mapper)
        {
            this.characterCollectionService = characterCollectionService;
            this.mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<VillainModel>>> Get()
        {
            var villains = await characterCollectionService.GetAllVillains();
            return Ok((villains));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<VillainModel>>> GetById(int id)
        {
            var villain = await characterCollectionService.GetVillainById(id);
            if (villain is null)
            {
                return NotFound($"Villain with id {id} not found.");
            }
            var villainModel = mapper.Map<VillainModel>(villain);
            return Ok(villainModel);
        }

        [HttpPost]
        public async Task<ActionResult<VillainModel>> Add([FromBody] VillainModel villainModel)
        {
            var villain = mapper.Map<Villain>(villainModel);
            var villainAdded = await characterCollectionService.AddVillain(villain);

            return CreatedAtAction(nameof(GetById), new { villainAdded.Id }, villainAdded);
        }

        [HttpPut]
        public async Task<ActionResult<VillainModel>> Update([FromBody] Villain villain)
        {
            await characterCollectionService.UpdateVillain(villain);
            return CreatedAtAction(nameof(GetById), new { villain.Id }, villain);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<VillainModel>> Delete(int id)
        {
            await characterCollectionService.DeleteVillainById(id);
            return Ok($"Villain with id {id} deleted");
        }
    }
}
