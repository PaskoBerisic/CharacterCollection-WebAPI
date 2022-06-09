using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class CharacterCollectionService : ICharacterCollectionService
    {
        private readonly IRepository<Hero> heroRepository;
        private readonly IRepository<Hero> villainRepository;

        public CharacterCollectionService(IRepository<Hero> heroRepository, IRepository<Hero> villainRepository)
        {
            this.heroRepository = heroRepository;
            this.villainRepository = villainRepository;
        }

        public async Task<IEnumerable<Hero>> GetAllHeroes()
        {
            return await heroRepository.GetAllAsync();
        }

        public async Task<Hero> GetHeroById(int id)
        {
            return await heroRepository.GetByIdAsync(id);
        }

        public async Task<Hero> GetHeroByName(string name)
        {
            return await heroRepository.GetByNameAsync(name);
        }

        public async Task<Hero> AddHero(Hero character)
        {
            return await heroRepository.AddAsync(character);
        }

        public async Task UpdateHero(Hero character)
        {
            await heroRepository.UpdateAsync(character);
        }

        public async Task DeleteHero(int id)
        {
            await heroRepository.DeleteAsync(id);
        }
    }
}
