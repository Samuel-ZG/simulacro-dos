using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WellnessHubAPI.Data;
using WellnessHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WellnessHubAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HabitsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HabitsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Habit>>> GetAll()
        {
            return await _context.Habits.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Habit>> Get(int id)
        {
            var habit = await _context.Habits.FindAsync(id);
            if (habit == null) return NotFound();
            return habit;
        }

        [HttpPost]
        public async Task<ActionResult<Habit>> Create([FromBody] Habit habit)
        {
            _context.Habits.Add(habit);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = habit.Id }, habit);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Habit habit)
        {
            if (id != habit.Id) return BadRequest();

            _context.Entry(habit).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var habit = await _context.Habits.FindAsync(id);
            if (habit == null) return NotFound();

            _context.Habits.Remove(habit);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}