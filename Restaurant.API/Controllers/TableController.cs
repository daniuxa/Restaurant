using AutoMapper;
using Restaurant.Dal.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Bll.Models.TableDTOs;
using Restaurant.Bll.Services.Interfaces;

namespace Restaurant.API.Controllers
{
    [ApiController]
    [Produces("application/json", "application/xml")]
    public class TableController : ControllerBase
    {
        private readonly ITableService _tableService;
        private readonly IMapper _mapper;

        public TableController(ITableService tableService, IMapper mapper)
        {
            this._tableService = tableService ?? throw new ArgumentNullException(nameof(tableService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("api/tables/{tableNumber}", Name = "GetTable")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TableDTO>> GetTable(int tableNumber)
        {
            var table = await _tableService.GetTableAsync(tableNumber);
            if (table == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<TableDTO>(table));
        }

        [HttpPost("api/tables")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<TableDTO>> CreateTable(TableForCreationDTO table)
        {
            var finaleTable = _mapper.Map<Table>(table);
            var addedTable = await _tableService.AddTableAsync(finaleTable);
            await _tableService.SaveChangesAsync();
            var tableToReturn = _mapper.Map<TableDTO>(addedTable);
            return CreatedAtRoute("GetTable", new { tableToReturn.TableNumber }, tableToReturn);

        }

    }
}
