using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
namespace ApplicationCore.Interfaces
{
    public interface ICharacterCollectionService
    {
        Task<IEnumerable<Hero>> GetAllHeroes();
        Task<Hero> GetHeroById(int id);
        Task<Hero> GetHeroByName(string name);
        Task<Hero> AddHero(Hero hero);
        Task UpdateHero(Hero hero);
        Task DeleteHero(Hero hero);
        Task DeleteHeroById(int id);
        //Custom

        Task<IEnumerable<Villain>> GetAllVillains();
        Task<Villain> GetVillainById(int id);
        Task<Villain> GetVillainByName(string name);
        Task<Villain> AddVillain(Villain villain);
        Task UpdateVillain(Villain villain);
        Task DeleteVillain(Villain villain);
        Task DeleteVillainById(int id);
    }
}
