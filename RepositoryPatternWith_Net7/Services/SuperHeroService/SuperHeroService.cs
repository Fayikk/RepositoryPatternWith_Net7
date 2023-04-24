using RepositoryPatternWith_Net7.Models;

namespace RepositoryPatternWith_Net7.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero
                {Id=1
                ,Name = "Spider Man"
                ,FirstName="Peter"
                ,LastName="Parker"
                ,Place = "New York City"},
                   new SuperHero
                {Id=2
                ,Name = "Super Man"
                ,FirstName="Pete"
                ,LastName="Lambo"
                ,Place = "London City"},
                      new SuperHero
                {Id=2
                ,Name = "Venom"
                ,FirstName="Dark"
                ,LastName="Vader"
                ,Place = "Oklohama City"}
            };
        public SuperHero AddHero(SuperHero newHero)
        {
           superHeroes.Add(newHero);
            return newHero;
        }

        public SuperHero DeleteHero(int id)
        {
            var result = superHeroes.Find(x => x.Id == id);
            superHeroes.Remove(result);
            return result;
        }

        public List<SuperHero> GetAllHeroes()
        {
            var result = superHeroes.ToList();
            return result;

        }

        public SuperHero GetHeroById(int id)
        {
            var result = superHeroes.Find(x => x.Id == id);
            return result;
        }

        public SuperHero UpdateHero(int id, SuperHero request)
        {
            var hero = superHeroes.FirstOrDefault(x => x.Id == id);
            if (hero == null)
            {
                return null;
            }
            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            return request;
        }
    }
}
