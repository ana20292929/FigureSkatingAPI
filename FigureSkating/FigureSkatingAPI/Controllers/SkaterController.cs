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
    public class SkaterController : ControllerBase
    {
        private readonly FigureSkatingAPIDBContext _context;

        public SkaterController(FigureSkatingAPIDBContext context)
        {
            _context = context;
        }

        // GET: api/Skater
        [HttpGet]
        public async Task<ActionResult<Response>> GetSkaters()
        {
            var response = new Response();

            if (_context.Skaters == null)
            {
                response.statusCode = 404;
                response.statusDescription = "Not Found: Empty";
                return response;
            }

            response.statusCode = 200;
            response.statusDescription = "Ok: Fetched All Skaters";
            response.SkatersList = await _context.Skaters.ToListAsync();

            return response;
        }

        // GET: api/Skater/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Response>> GetSkater(int id)
        {
            var response = new Response();

            var skater = await _context.Skaters.FindAsync(id);

            if (skater == null)
            {
                response.statusCode = 404;
                response.statusDescription = "Not Found: This Skater Doesn't Exist";
                return response;
            }

            response.SkatersList.Add(skater);
            response.statusCode = 200;
            response.statusDescription = "Ok: Fetched Requested Skater";

            return response;
        }

        // PUT: api/Skater/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<Response> PutSkater(int id, Skater skater)
        {
            var response = new Response();

            if (id != skater.SkaterId)
            {
                response.statusCode = 400;
                response.statusDescription = "Bad Request: ID in URL doens't match ID in JSON";
                return response;
            }

            _context.Entry(skater).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkaterExists(id))
                {
                    response.statusCode = 404;
                    response.statusDescription = "Not Found: This Skater Doesn't Exist";
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

        // POST: api/Skater
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<Response> PostSkater(Skater skater)
        {
            var response = new Response();

            _context.Skaters.Add(skater);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SkaterExists(skater.SkaterId))
                {
                    response.statusCode = 409;
                    response.statusDescription = "Conflict: This Skater Already Exists";
                    return response;
                }
                else
                {
                    throw;
                }
            }

            response.statusCode = 201;
            response.statusDescription = "Created New Skater";
            return response;
        }

        // DELETE: api/Skater/5
        [HttpDelete("{id}")]
        public async Task<Response> DeleteSkater(int id)
        {
            var response = new Response();
            if (_context.Skaters == null)
            {
                response.statusCode = 404;
                response.statusDescription = "Not Found: Empty";
                return response;
            }

            var skater = await _context.Skaters.FindAsync(id);
            if (skater == null)
            {
                response.statusCode = 404;
                response.statusDescription = "Not Found: This Skater Doesn't Exist";
                return response;
            }

            _context.Skaters.Remove(skater);
            await _context.SaveChangesAsync();

            response.statusCode = 204;
            response.statusDescription = "No Content: Successfully Deleted";
            return response;
        }

        private bool SkaterExists(int id)
        {
            return (_context.Skaters?.Any(e => e.SkaterId == id)).GetValueOrDefault();
        }
    }
}
