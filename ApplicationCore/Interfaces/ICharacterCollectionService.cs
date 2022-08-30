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
    }
}
