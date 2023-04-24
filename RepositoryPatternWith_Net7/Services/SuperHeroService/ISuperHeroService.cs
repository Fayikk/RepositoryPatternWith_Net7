using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWith_Net7.Models;

namespace RepositoryPatternWith_Net7.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
       List<SuperHero> GetAllHeroes();
       SuperHero GetHeroById(int id);
       SuperHero UpdateHero(int id, SuperHero request);
        SuperHero DeleteHero(int id);
        SuperHero AddHero(SuperHero newHero);
    }
}
