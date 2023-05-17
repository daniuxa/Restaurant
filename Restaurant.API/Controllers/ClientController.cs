using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Bll.Models.ClientDTOs;
using Restaurant.Bll.Services.Interfaces;
using Restaurant.Dal.Entities;

namespace Restaurant.API.Controllers
{
    [ApiController]
    [Produces("application/json", "application/xml")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientController(IClientService clientService, IMapper mapper)
        {
            this._clientService = clientService;
            this._mapper = mapper;
        }

        [HttpGet("api/clients/{clientId}", Name = "GetClient")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClientDTO>> GetClient(int clientId)
        {
            var client = await _clientService.GetClientAsync(clientId);
            if (client == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ClientDTO>(client));
        }

        [HttpPost("api/clients")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ClientDTO>> CreateClient(ClientForCreationDTO clientForCreation)
        {
            var finalClient = _mapper.Map<Client>(clientForCreation);
            //Add wine and link to db
            var clientAdded = await _clientService.AddClientAsync(finalClient);
            //SaveChanges
            await _clientService.SaveChangesAsync();
            //To return value
            var clientToReturn = _mapper.Map<ClientDTO>(clientAdded);
            //CreatedAtRoute
            return CreatedAtRoute("GetClient", new { clientToReturn.ClientId }, clientToReturn);
        }

        [HttpGet("api/clients")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ClientDTO>>> GetClients()
        {
            var clients = await _clientService.GetClientsAsync();
            return Ok(_mapper.Map<IEnumerable<ClientDTO>>(clients));
        }
    }
}
