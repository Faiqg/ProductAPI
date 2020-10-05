using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Refactored.This.Data;
using Refactored.This.Model.Entities;

namespace Refactored.This.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOptionsController : ControllerBase
    {
        private readonly RefactorContext _context;

        public ProductOptionsController(RefactorContext context)
        {
            _context = context;
        }

        // GET: api/ProductOptions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductOption>>> GetProductOptions()
        {
            return await _context.ProductOption.ToListAsync();
        }

        // GET: api/ProductOptions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductOption>> GetProductOption(Guid id)
        {
            var productOption = await _context.ProductOption.FindAsync(id);

            if (productOption == null)
            {
                return NotFound();
            }

            return productOption;
        }

        // PUT: api/ProductOptions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductOption(Guid id, ProductOption productOption)
        {
            if (id != productOption.Id)
            {
                return BadRequest();
            }

            _context.Entry(productOption).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductOptionExists(id))
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

        // POST: api/ProductOptions
        [HttpPost]
        public async Task<ActionResult<ProductOption>> PostProductOption(ProductOption productOption)
        {
            _context.ProductOption.Add(productOption);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductOption", new { id = productOption.Id }, productOption);
        }

        // DELETE: api/ProductOptions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductOption>> DeleteProductOption(Guid id)
        {
            var productOption = await _context.ProductOption.FindAsync(id);
            if (productOption == null)
            {
                return NotFound();
            }

            _context.ProductOption.Remove(productOption);
            await _context.SaveChangesAsync();

            return productOption;
        }

        private bool ProductOptionExists(Guid id)
        {
            return _context.ProductOption.Any(e => e.Id == id);
        }
    }
}
