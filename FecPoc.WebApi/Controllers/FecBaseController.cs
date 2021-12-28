using FecPoc.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FecPoc.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class FecBaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public FecBaseController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/{guid}
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(Guid id)
        {
            var movie = await repository.Get(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        // PUT: api/[controller]/{guid}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, TEntity movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }
            await repository.Update(movie);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity partner)
        {
            await repository.Add(partner);
            return CreatedAtAction("Get", new { id = partner.Id }, partner);
        }

        // DELETE: api/[controller]/{guid}
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(Guid id)
        {
            var partner = await repository.Delete(id);
            if (partner == null)
            {
                return NotFound();
            }
            return partner;
        }

    }
}
