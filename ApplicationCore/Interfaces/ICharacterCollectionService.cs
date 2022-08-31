using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ApplicationCore.Interfaces
{
    public interface ICharacterCollectionService
    {
        Task<IEnumerable<Hero>> GetAllHeroes();
        Task<Hero> GetHeroById(int id);
        Task<Hero> GetHeroByName(string name);
        Task<Hero> AddHero(Hero hero);
        Task UpdateHero(Hero hero);
        Task DeleteHero(int id);

        Task<IEnumerable<Villain>> GetAllVillains();
        Task<Villain> GetVillainById(int id);
        Task<Villain> GetVillainByName(string name);
        Task<Villain> AddVillain(Villain villain);
        Task UpdateVillain(Villain villain);
        Task DeleteVillain(int id);

    }
}
