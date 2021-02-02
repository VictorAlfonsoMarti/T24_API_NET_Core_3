﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using T24_API_NET_Core_3.Models;

namespace T24_API_NET_Core_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CientificosController : ControllerBase
    {
        private readonly APIContext _context;

        public CientificosController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Cientificos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cientifico>>> GetCientificos()
        {
            return await _context.Cientificos.ToListAsync();
        }

        // GET: api/Cientificos/5
        [HttpGet("{dni}")]
        public async Task<ActionResult<Cientifico>> GetCientifico(string id)
        {
            var cientifico = await _context.Cientificos.FindAsync(id);

            if (cientifico == null)
            {
                return NotFound();
            }

            return cientifico;
        }

        // PUT: api/Cientificos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{dni}")]
        public async Task<IActionResult> PutCientifico(string id, Cientifico cientifico)
        {
            if (id != cientifico.Dni)
            {
                return BadRequest();
            }

            _context.Entry(cientifico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CientificoExists(id))
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

        // POST: api/Cientificos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cientifico>> PostCientifico(Cientifico cientifico)
        {
            _context.Cientificos.Add(cientifico);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CientificoExists(cientifico.Dni))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCientifico", new { id = cientifico.Dni }, cientifico);
        }

        // DELETE: api/Cientificos/5
        [HttpDelete("{dni}")]
        public async Task<ActionResult<Cientifico>> DeleteCientifico(string id)
        {
            var cientifico = await _context.Cientificos.FindAsync(id);
            if (cientifico == null)
            {
                return NotFound();
            }

            _context.Cientificos.Remove(cientifico);
            await _context.SaveChangesAsync();

            return cientifico;
        }

        private bool CientificoExists(string id)
        {
            return _context.Cientificos.Any(e => e.Dni == id);
        }
    }
}
