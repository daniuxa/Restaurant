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
        [ProducesResponseType(StatusCodes.Status200OK)]
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

        [HttpGet("api/tables")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<TableDTO>>> GetTables()
        {
            var tables = await _tableService.GetTablesAsync();
            return Ok(_mapper.Map<IEnumerable<TableDTO>>(tables));
        }
        [HttpDelete("api/tables/{tableNumber}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteTable(int tableNumber)
        {
            var tableToDelete = await _tableService.GetTableAsync(tableNumber);
            if (tableToDelete == null)
            {
                return NotFound();
            }
            _tableService.DeleteTable(tableToDelete);
            await _tableService.SaveChangesAsync();
            return NoContent();
        }
    }
}
