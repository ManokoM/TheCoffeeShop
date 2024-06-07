using Microsoft.AspNetCore.Mvc;
using TheCoffeeShop.Models;
using TheCoffeeShop.Services;

namespace TheCoffeeShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientsController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            return Ok(await _clientRepository.GetClients());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(int id)
        {
            var client = await _clientRepository.GetClient(id);

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }

        [HttpPost]
        public async Task<ActionResult<Client>> AddClient(Client client)
        {
            await _clientRepository.AddClient(client);
            return CreatedAtAction(nameof(GetClient), new { id = client.ClientId }, client);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, Client client)
        {
            if (id != client.ClientId)
            {
                return BadRequest();
            }

            await _clientRepository.UpdateClient(client);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            await _clientRepository.DeleteClient(id);
            return NoContent();
        }
    }
}
