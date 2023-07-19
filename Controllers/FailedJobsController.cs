using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Example07New.Context;
using Example07New.Models;

namespace Example07.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FailedJobsController : ControllerBase
    {
        private readonly Example07Context _context;

        public FailedJobsController(Example07Context context)
        {
            _context = context;
        }

        // GET: api/FailedJobs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FailedJob>>> GetFailedJobs()
        {
            if (_context.FailedJobs == null)
            {
                return NotFound();
            }
            return await _context.FailedJobs.ToListAsync();
        }

        // GET: api/FailedJobs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FailedJob>> GetFailedJob(long id)
        {
            if (_context.FailedJobs == null)
            {
                return NotFound();
            }
            var failedJob = await _context.FailedJobs.FindAsync(id);

            if (failedJob == null)
            {
                return NotFound();
            }

            return failedJob;
        }

        // PUT: api/FailedJobs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFailedJob(long id, FailedJob failedJob)
        {
            if (id != failedJob.Id)
            {
                return BadRequest();
            }

            _context.Entry(failedJob).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FailedJobExists(id))
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

        // POST: api/FailedJobs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FailedJob>> PostFailedJob(FailedJob failedJob)
        {
            if (_context.FailedJobs == null)
            {
                return Problem("Entity set 'Example07Context.FailedJobs'  is null.");
            }
            _context.FailedJobs.Add(failedJob);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFailedJob", new { id = failedJob.Id }, failedJob);
        }

        // DELETE: api/FailedJobs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFailedJob(long id)
        {
            if (_context.FailedJobs == null)
            {
                return NotFound();
            }
            var failedJob = await _context.FailedJobs.FindAsync(id);
            if (failedJob == null)
            {
                return NotFound();
            }

            _context.FailedJobs.Remove(failedJob);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FailedJobExists(long id)
        {
            return (_context.FailedJobs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
