using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Bll.Models.DishDTOs;
using Restaurant.Bll.Services.Interfaces;
using Restaurant.Dal.Entities;

namespace Restaurant.API.Controllers
{
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly IDishService _dishService;
        private readonly ICloudImageService _cloudImageService;
        private readonly IMapper _mapper;

        public DishController(IDishService dishService, ICloudImageService cloudImageService, IMapper mapper)
        {
            this._dishService = dishService ?? throw new ArgumentNullException(nameof(dishService));
            this._cloudImageService = cloudImageService ?? throw new ArgumentNullException(nameof(cloudImageService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("api/dishes")]
        public async Task<ActionResult<DishForListDTO>> GetDishList()
        {
            var wines = await _dishService.GetDishesAsync();

            return Ok(_mapper.Map<IEnumerable<DishForListDTO>>(wines));
        }

        [HttpGet("api/dishes/{PositionId}", Name = "GetDish")]
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
        public async Task<ActionResult<DishDetailInfoDTO>> CreateDish([FromForm] DishCreationDTO dish)
        {
            var finalDish = _mapper.Map<Dish>(dish);
            //Add photo to db and get a link
            var (positionId, photoLink) = await _cloudImageService.UploadImageToCloud(dish.photo);
            //Add wine and link to db
            var dishAdded = await _dishService.AddDishAsync(positionId, finalDish, photoLink);
            //SaveChanges
            await _dishService.SaveChangesAsync();
            //To return value
            var dishToReturn = _mapper.Map<DishDetailInfoDTO>(dishAdded);
            //CreatedAtRoute
            return CreatedAtRoute("GetWine", new { PositionId = dishToReturn.PositionId }, dishToReturn);
        }

        [HttpDelete("api/dishes")]
        public async Task<IActionResult> DeleteAllDishes()
        {
            await _dishService.DeleteAllDishes();
            await _dishService.SaveChangesAsync();
            return NoContent();
        }
    }
}
