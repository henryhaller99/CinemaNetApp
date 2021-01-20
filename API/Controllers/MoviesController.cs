using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly DataContext _context;
        public MoviesController(DataContext context)
        {
            this._context = context;
        }

        // [HttpGet]
        // public ActionResult<IEnumerable<Movie>> GetMovies()
        // {
        //     return _context.Movies.ToList();            
        // }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovie(){
            return await _context.Movies.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            return await _context.Movies.FindAsync(id);            
        }


    }
}