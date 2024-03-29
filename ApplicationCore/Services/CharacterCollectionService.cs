﻿using ApplicationCore.Entities;
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
        private readonly IRepository<Villain> villainRepository;

        public CharacterCollectionService(IRepository<Hero> heroRepository, IRepository<Villain> villainRepository)
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

        public async Task<Hero> AddHero(Hero hero)
        {
            return await heroRepository.AddAsync(hero);
        }

        public async Task UpdateHero(Hero hero)
        {
            await heroRepository.UpdateAsync(hero);
        }

        public async Task DeleteHero(int id)
        {
            await heroRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Villain>> GetAllVillains()
        {
            return await villainRepository.GetAllAsync();
        }

        public async Task<Villain> GetVillainById(int id)
        {
            return await villainRepository.GetByIdAsync(id);
        }

        public async Task<Villain> GetVillainByName(string name)
        {
            return await villainRepository.GetByNameAsync(name);
        }

        public async Task<Villain> AddVillain(Villain villain)
        {
            return await villainRepository.AddAsync(villain);
        }

        public async Task UpdateVillain(Villain villain)
        {
            await villainRepository.UpdateAsync(villain);
        }

        public async Task DeleteVillain(int id)
        {
            await villainRepository.DeleteAsync(id);
        }
    }
}
