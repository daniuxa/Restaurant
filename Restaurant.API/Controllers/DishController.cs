using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Bll.Models.DishDTOs;
using Restaurant.Bll.Services.Interfaces;
using Restaurant.Dal.Entities;

namespace Restaurant.API.Controllers
{
    [ApiController]
    [Produces("application/json", "application/xml")]
    public class DishController : ControllerBase
    {
        private readonly IDishService _dishService;
        private readonly ICloudImageService _cloudImageService;
        private readonly IMapper _mapper;
        private const string folderName = "Menu";

        public DishController(IDishService dishService, ICloudImageService cloudImageService, IMapper mapper)
        {
            this._dishService = dishService ?? throw new ArgumentNullException(nameof(dishService));
            this._cloudImageService = cloudImageService ?? throw new ArgumentNullException(nameof(cloudImageService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


        [HttpGet("api/dishes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDishList(bool dividedByType = false)
        {
            if (dividedByType)
            {
                var dishesDictionary = await _dishService.GetDictionaryDishesAsync();
                
                return Ok(_mapper.Map<Dictionary<string, IEnumerable<DishForListDTO>>>(dishesDictionary));
            }
            var dishes = await _dishService.GetDishesAsync();
            return Ok(_mapper.Map<IEnumerable<DishForListDTO>>(dishes));
        }

        [HttpGet("api/dishes/{PositionId}", Name = "GetDish")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DishDetailInfoDTO>> GetDish(Guid PositionId)
        {
            var dish = await _dishService.GetDishAsync(PositionId);
            if (dish == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DishDetailInfoDTO>(dish));
        }

        [HttpPost("api/dishes")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<DishDetailInfoDTO>> CreateDish([FromForm] DishCreationDTO dish)
        {
            var finalDish = _mapper.Map<Dish>(dish);
            //Add photo to db and get a link
            var (positionId, photoLink) = await _cloudImageService.UploadImageToCloud(dish.photo, folderName);
            //Add wine and link to db
            var dishAdded = await _dishService.AddDishAsync(positionId, finalDish, photoLink);
            //SaveChanges
            await _dishService.SaveChangesAsync();
            //To return value
            var dishToReturn = _mapper.Map<DishDetailInfoDTO>(dishAdded);
            //CreatedAtRoute
            return CreatedAtRoute("GetWine", new { dishToReturn.PositionId }, dishToReturn);
        }

        [HttpDelete("api/dishes")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAllDishes()
        {
            await _dishService.DeleteAllDishes();
            await _dishService.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("api/dishes/{positionId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteDish(Guid positionId)
        {
            var dishToDelete = await _dishService.GetDishAsync(positionId);
            if (dishToDelete == null)
            {
                return NotFound();
            }
            _dishService.DeleteDish(dishToDelete);
            await _dishService.SaveChangesAsync();
            return NoContent();
        }
    }
}
