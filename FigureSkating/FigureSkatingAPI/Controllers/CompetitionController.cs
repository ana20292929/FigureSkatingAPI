using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FigureSkatingAPI.Models;

namespace FigureSkatingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionController : ControllerBase
    {
        private readonly FigureSkatingAPIDBContext _context;

        public CompetitionController(FigureSkatingAPIDBContext context)
        {
            _context = context;
        }

        // GET: api/Competition
        [HttpGet]
        public async Task<ActionResult<Response>> GetCompetitions()
        {
            var response = new Response();

            if (_context.Competitions == null)
            {
                response.statusCode = 404;
                response.statusDescription = "Not Found: Empty";
                return response;
            }

            response.statusCode = 200;
            response.statusDescription = "Ok: Fetched All Competitions";
            response.CompetitionsList = await _context.Competitions.ToListAsync();
            return response;
        }

        // GET: api/Competition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Response>> GetCompetition(int id)
        {
            var response = new Response();

            var competition = await _context.Competitions.FindAsync(id);

            if (competition == null)
            {
                response.statusCode = 404;
                response.statusDescription = "Not Found: This Competition Doesn't Exist";
                return response;
            }

            response.statusCode = 200;
            response.statusDescription = "Ok: Fetched Requested Competition";
            response.CompetitionsList.Add(competition);

            return response;
        }

        // PUT: api/Competition/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<Response> PutCompetition(int id, Competition competition)
        {
            var response = new Response();

            if (id != competition.CompetitionId)
            {
                response.statusCode = 400;
                response.statusDescription = "Bad Request: ID in URL doens't match ID in JSON";
                return response;
            }

            _context.Entry(competition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompetitionExists(id))
                {
                    response.statusCode = 404;
                    response.statusDescription = "Not Found: This Competition Doesn't Exist";
                    return response;
                }
                else
                {
                    throw;
                }
            }

            response.statusCode = 204;
            response.statusDescription = "No Content: Successfully Updated";
            return response;
        }

        // POST: api/Competition
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Response>> PostCompetition(Competition competition)
        {
            var response = new Response();

            _context.Competitions.Add(competition);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CompetitionExists(competition.CompetitionId))
                {
                    response.statusCode = 409;
                    response.statusDescription = "Conflict: This Competition Already Exists";
                    return response;
                }
                else
                {
                    throw;
                }
            }

            response.statusCode = 201;
            response.statusDescription = "Created New Competition";
            return response;
        }

        // DELETE: api/Competition/5
        [HttpDelete("{id}")]
        public async Task<Response> DeleteCompetition(int id)
        {
            var response = new Response();

            if (_context.Competitions == null)
            {
                response.statusCode = 404;
                response.statusDescription = "Not Found: Empty";
                return response;
            }

            var competition = await _context.Competitions.FindAsync(id);

            if (competition == null)
            {
                response.statusCode = 404;
                response.statusDescription = "Not Found: This Competition Doesn't Exist";
                return response;
            }

            _context.Competitions.Remove(competition);
            await _context.SaveChangesAsync();

            response.statusCode = 204;
            response.statusDescription = "No Content: Successfully Deleted";
            return response;
        }

        private bool CompetitionExists(int id)
        {
            return (_context.Competitions?.Any(e => e.CompetitionId == id)).GetValueOrDefault();
        }
    }
}
