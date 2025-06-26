using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiEFtst.Data;
using apiEFtst.Models;

namespace apiEFtst.Controllers 
{
    [ApiController]
    [Route("v1/clients")]
    public class ClientController : ControllerBase 
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Client>>> Get([FromServices] DataContext context)
        {
            var clients = await context.Clients.ToListAsync();
            return clients;
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Client>> GetById([FromServices] DataContext context, int id)
        {
            var client = await context.Clients.FindAsync(id);
            if (client == null)
                return NotFound();
            return client;    
        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Client>> Post(
            [FromServices] DataContext context,
            [FromBody] Client model
        )
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            context.Clients.Add(model);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new {id = model.Id }, model);
        }
    }
}