using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Bll.Models.OrderDTOs.DeliveryOrderDTOs;
using Restaurant.Bll.Models.OrderDTOs.InRestaurantOrderDTOs;
using Restaurant.Bll.Services.Interfaces;
using Restaurant.Dal.Entities;

namespace Restaurant.API.Controllers
{
    [Produces("application/json", "application/xml")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IInRestaurantOrderService _inRestaurantOrderService;
        private readonly IDeliveryOrderService _deliveryOrderService;
        private readonly IMapper _mapper;

        public OrderController(IInRestaurantOrderService inRestaurantOrderService, IDeliveryOrderService deliveryOrderService, IMapper mapper)
        {
            this._inRestaurantOrderService = inRestaurantOrderService ?? throw new ArgumentNullException(nameof(inRestaurantOrderService));
            this._deliveryOrderService = deliveryOrderService ?? throw new ArgumentNullException(nameof(deliveryOrderService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("api/orders", Name = "GetOrder")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetOrder(int orderId)
        {
            DeliveryOrder? deliveryOrder = await _deliveryOrderService.GetOrderAsync(orderId);
            InRestaurantOrder? inRestaurantOrder = null;
            if (deliveryOrder == null)
            {
                inRestaurantOrder = await _inRestaurantOrderService.GetOrderAsync(orderId);
            }
            if (deliveryOrder == null && inRestaurantOrder == null)
            {
                return NotFound();
            }

            return deliveryOrder == null ? Ok(_mapper.Map<InRestaurantOrderDTO>(inRestaurantOrder) : Ok(_mapper.Map<DeliveryOrderDTO>(deliveryOrder));
        }

        [HttpPost("api/orders/delivery")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<DeliveryOrderDTO>> CreateDish(DishCreationDTO dish)
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
    }
}
