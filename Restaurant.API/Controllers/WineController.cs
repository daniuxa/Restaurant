using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Bll.Models.WineDTOs;
using Restaurant.Bll.Services.Interfaces;

namespace Restaurant.API.Controllers
{
    [ApiController]
    public class WineController : ControllerBase
    {
        private readonly IWineService _wineService;
        private readonly IMapper _mapper;

        public WineController(IWineService wineService, IMapper mapper)
        {
            this._wineService = wineService ?? throw new ArgumentNullException(nameof(wineService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("api/wines")]
        public async Task<ActionResult<WineForListDTO>> GetWineList()
        {
            var wines = await _wineService.GetWineListAsync();

            return Ok(_mapper.Map<IEnumerable<WineForListDTO>>(wines));
        }
        [HttpGet("api/wines/{PositionId}")]
        public async Task<ActionResult<WineDetailInfoDTO>> GetWine(Guid PositionId)
        {
            var wine = await _wineService.GetWineAsync(PositionId);
            if (wine == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<WineDetailInfoDTO>(wine));
        }
    }
}
