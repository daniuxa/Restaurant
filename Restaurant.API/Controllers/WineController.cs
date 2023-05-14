using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Bll.Models.WineDTOs;
using Restaurant.Bll.Services.Interfaces;
using Restaurant.Dal.Entities;

namespace Restaurant.API.Controllers
{
    [ApiController]
    [Produces("application/json", "application/xml")]
    public class WineController : ControllerBase
    {
        private readonly IWineService _wineService;
        private readonly ICloudImageService _cloudImageService;
        private readonly IMapper _mapper;
        private const string folderName = "Menu";

        public WineController(IWineService wineService, ICloudImageService cloudImageService, IMapper mapper)
        {
            this._wineService = wineService ?? throw new ArgumentNullException(nameof(wineService));
            this._cloudImageService = cloudImageService ?? throw new ArgumentNullException(nameof(cloudImageService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("api/wines")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetWineList(bool dividedByCountry = false)
        {
            if (dividedByCountry)
            {
                var wineDictionary = await _wineService.GetDictionaryWinesAsync();

                return Ok(_mapper.Map<Dictionary<string, IEnumerable<WineForListDTO>>>(wineDictionary));
            }
            var wines = await _wineService.GetWinesAsync();

            return Ok(_mapper.Map<IEnumerable<WineForListDTO>>(wines));
        }
        [HttpGet("api/wines/{PositionId}", Name = "GetWine")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<WineDetailInfoDTO>> GetWine(Guid PositionId)
        {
            var wine = await _wineService.GetWineAsync(PositionId);
            if (wine == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<WineDetailInfoDTO>(wine));
        }

        [HttpPost("api/wines")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<WineDetailInfoDTO>> CreateWine([FromForm]WineCreationDTO wine)
        {
            var finalWine = _mapper.Map<Wine>(wine);
            //Add photo to db and get a link
            var (positionId, photoLink) = await _cloudImageService.UploadImageToCloud(wine.photo, folderName);
            //Add wine and link to db
            var wineAdded = await _wineService.AddWineAsync(positionId, finalWine, photoLink);
            //SaveChanges
            await _wineService.SaveChangesAsync();
            //To return value
            var wineToReturn = _mapper.Map<WineDetailInfoDTO>(wineAdded);
            //CreatedAtRoute
            return CreatedAtRoute("GetWine", new {PositionId = wineToReturn.PositionId}, wineToReturn);
        }

        [HttpDelete("api/wines")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAllWines()
        {
            await _wineService.DeleteAllWines();
            await _wineService.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("api/wines/{positionId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteDish(Guid PositionId)
        {
            var wineToDelete = await _wineService.GetWineAsync(PositionId);
            if (wineToDelete == null)
            {
                return NotFound();
            }
            _wineService.DeleteWine(wineToDelete);
            await _wineService.SaveChangesAsync();
            return NoContent();
        }
    }
}
