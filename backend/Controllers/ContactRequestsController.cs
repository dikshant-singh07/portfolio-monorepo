using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Data;
using PortfolioAPI.Models;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactRequestsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContactRequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ContactRequests (For your future Admin Dashboard!)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactRequest>>> GetContactRequests()
        {
            return await _context.ContactRequests
                                 .OrderByDescending(c => c.CreatedAt)
                                 .ToListAsync();
        }

        // POST: api/ContactRequests (What your Angular contact form will call)
        [HttpPost]
        public async Task<ActionResult<ContactRequest>> SubmitContactRequest(ContactRequest contactRequest)
        {
            // Automatically set the timestamp to right now
            contactRequest.CreatedAt = DateTime.UtcNow;
            
            _context.ContactRequests.Add(contactRequest);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetContactRequests), new { id = contactRequest.Id }, contactRequest);
        }
    }
}