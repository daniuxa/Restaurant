using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Bll.Models.DrinkDTOs;
using Restaurant.Bll.Services.Interfaces;
using Restaurant.Dal.Entities;

namespace Restaurant.API.Controllers
{
    [ApiController]
    [Produces("application/json", "application/xml")]
    public class DrinkController : ControllerBase
    {
        private readonly IDrinkService _drinkService;
        private readonly ICloudImageService _cloudImageService;
        private readonly IMapper _mapper;
        private const string folderName = "Menu";

        public DrinkController(IDrinkService drinkService, ICloudImageService cloudImageService, IMapper mapper)
        {
            this._drinkService = drinkService ?? throw new ArgumentNullException(nameof(drinkService));
            this._cloudImageService = cloudImageService ?? throw new ArgumentNullException(nameof(cloudImageService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet("api/drinks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDrinkList(bool dividedByType = false)
        {
            if (dividedByType)
            {
                var drinksDictionary = await _drinkService.GetDictionaryDrinksAsync();

                return Ok(_mapper.Map<Dictionary<string, IEnumerable<DrinkForListDTO>>>(drinksDictionary));
            }

            var drinks = await _drinkService.GetDrinksAsync();

            return Ok(_mapper.Map<IEnumerable<DrinkForListDTO>>(drinks));
        }
        [HttpGet("api/drinks/{PositionId}", Name = "GetDrink")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DrinkDetailInfoDTO>> GetDrink(Guid PositionId)
        {
            var drink = await _drinkService.GetDrinkAsync(PositionId);
            if (drink == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DrinkDetailInfoDTO>(drink));
        }

        [HttpPost("api/drinks")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<DrinkDetailInfoDTO>> CreateWine([FromForm] DrinkCreationDTO drink)
        {
            var finalDrink = _mapper.Map<Drink>(drink);
            //Add photo to db and get a link
            var (positionId, photoLink) = await _cloudImageService.UploadImageToCloud(drink.photo, folderName);
            //Add wine and link to db
            var drinkAdded = await _drinkService.AddDrinkAsync(positionId, finalDrink, photoLink);
            //SaveChanges
            await _drinkService.SaveChangesAsync();
            //To return value
            var drinkToReturn = _mapper.Map<DrinkDetailInfoDTO>(drinkAdded);
            //CreatedAtRoute
            return CreatedAtRoute("GetDrink", new { PositionId = drinkToReturn.PositionId }, drinkToReturn);
        }

        [HttpDelete("api/drinks")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAllDrinks()
        {
            await _drinkService.DeleteAllDrinks();
            await _drinkService.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("api/drinks/{positionId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteDrink(Guid positionId)
        {
            var drinkToDelete = await _drinkService.GetDrinkAsync(positionId);
            if (drinkToDelete == null)
            {
                return NotFound();
            }
            _drinkService.DeleteDrink(drinkToDelete);
            await _drinkService.SaveChangesAsync();
            return NoContent();
        }

    }
}
