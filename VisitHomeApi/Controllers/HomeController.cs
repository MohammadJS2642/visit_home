using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisitHomeApi.Data;
using VisitHomeApi.Models;

namespace VisitHomeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly VisitHomeContext _context;

        public HomeController(VisitHomeContext context)
        {
            _context = context;
        }

        // GET: api/Home
        [EnableCors]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Home>>> GetHomes()
        {
            return await _context.Homes.ToListAsync();
        }

        // GET: api/Home/5
        [EnableCors]
        [HttpGet("{id}")]
        public async Task<ActionResult<Home>> GetHome(Guid id)
        {
            var home = await _context.Homes.FindAsync(id);

            if (home == null)
            {
                return NotFound();
            }

            return home;
        }

        // PUT: api/Home/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [EnableCors]
        [HttpPut("{id}")]
        // [Route("/edit/{id}")]
        public async Task<IActionResult> PutHome(Guid id, Home home)
        {
            if (id != home.Id)
            {
                return BadRequest();
            }

            _context.Entry(home).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Home
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [EnableCors]
        [HttpPost]
        public async Task<ActionResult<Home>> PostHome(Home home)
        {
            _context.Homes.Add(home);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHome", new { id = home.Id }, home);
        }

        // DELETE: api/Home/5
        [EnableCors]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(Guid id)
        {
            var home = await _context.Homes.FindAsync(id);
            if (home == null)
            {
                return NotFound();
            }

            _context.Homes.Remove(home);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HomeExists(Guid id)
        {
            return _context.Homes.Any(e => e.Id == id);
        }
    }
}
