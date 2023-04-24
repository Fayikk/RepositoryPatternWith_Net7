using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWith_Net7.Models;
using RepositoryPatternWith_Net7.Services.SuperHeroService;

namespace RepositoryPatternWith_Net7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var result =  _superHeroService.GetAllHeroes();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetHeroById(int id)
        {
            var result = _superHeroService.GetHeroById(id);  
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SuperHero>> UpdateHero(int id, SuperHero request)
        {
           _superHeroService.UpdateHero(id, request);
            return Ok(request);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<SuperHero>> DeleteHero(int id)
        {
            var result = _superHeroService.DeleteHero(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<SuperHero>> AddHero(SuperHero newHero)
        {

            var result = _superHeroService.AddHero(newHero);
            return Ok(result);
        }



    }
}
