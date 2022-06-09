using ApplicationCore.Entities;
using AutoMapper;
using WebAPI.Models;

namespace WebAPI.Profiles
{
    public class CharacterCollectionProfile : Profile
    {
        public CharacterCollectionProfile()
        {
            CreateMap<Hero, HeroModel>().ReverseMap();
            CreateMap<Villain, VillainModel>().ReverseMap();
        }
    }
}
