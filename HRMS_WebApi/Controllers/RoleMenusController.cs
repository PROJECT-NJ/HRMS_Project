using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRMS_WebApi.Data;
using HRMS_WebApi.Models;

namespace HRMS_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleMenusController : ControllerBase
    {
        private readonly HrmsContext _context;

        public RoleMenusController(HrmsContext context)
        {
            _context = context;
        }

        // GET: api/RoleMenus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoleMenu>>> GetRoleMenu()
        {
            return await _context.RoleMenu.ToListAsync();
        }

        // GET: api/RoleMenus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoleMenu>> GetRoleMenu(string id)
        {
            var roleMenu = await _context.RoleMenu.FindAsync(id);

            if (roleMenu == null)
            {
                return NotFound();
            }

            return roleMenu;
        }

        // PUT: api/RoleMenus/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoleMenu(string id, RoleMenu roleMenu)
        {
            if (id != roleMenu.RoleId)
            {
                return BadRequest();
            }

            _context.Entry(roleMenu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleMenuExists(id))
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

        // POST: api/RoleMenus
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RoleMenu>> PostRoleMenu(RoleMenu roleMenu)
        {
            _context.RoleMenu.Add(roleMenu);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RoleMenuExists(roleMenu.RoleId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRoleMenu", new { id = roleMenu.RoleId }, roleMenu);
        }

        // DELETE: api/RoleMenus/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RoleMenu>> DeleteRoleMenu(string id)
        {
            var roleMenu = await _context.RoleMenu.FindAsync(id);
            if (roleMenu == null)
            {
                return NotFound();
            }

            _context.RoleMenu.Remove(roleMenu);
            await _context.SaveChangesAsync();

            return roleMenu;
        }

        private bool RoleMenuExists(string id)
        {
            return _context.RoleMenu.Any(e => e.RoleId == id);
        }
    }
}
