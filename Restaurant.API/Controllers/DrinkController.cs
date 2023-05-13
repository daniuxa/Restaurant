using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Bll.CustomMappers;
using Restaurant.Bll.Models.DrinkDTOs;
using Restaurant.Bll.Services.Interfaces;
using Restaurant.Dal.Entities;

namespace Restaurant.API.Controllers
{
    [ApiController]
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
        public async Task<IActionResult> GetDrinkList(bool dividedByType = false)
        {
            if (dividedByType)
            {
                var drinksDictionary = await _drinkService.GetDictionaryDrinksAsync();

                return Ok(DrinkMapper.MapDictionary(_mapper, drinksDictionary));
            }

            var drinks = await _drinkService.GetDrinksAsync();

            return Ok(_mapper.Map<IEnumerable<DrinkForListDTO>>(drinks));
        }
        [HttpGet("api/drinks/{PositionId}", Name = "GetDrink")]
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
        public async Task<IActionResult> DeleteAllDrinks()
        {
            await _drinkService.DeleteAllDrinks();
            await _drinkService.SaveChangesAsync();
            return NoContent();
        }
    }
}
