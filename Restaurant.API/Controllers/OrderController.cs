using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Bll;
using Restaurant.Bll.Models.ClientDTOs;
using Restaurant.Bll.Models.OrderDTOs;
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
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;

        public OrderController(IInRestaurantOrderService inRestaurantOrderService, IDeliveryOrderService deliveryOrderService, IEmailService emailService, IMapper mapper)
        {
            this._inRestaurantOrderService = inRestaurantOrderService ?? throw new ArgumentNullException(nameof(inRestaurantOrderService));
            this._deliveryOrderService = deliveryOrderService ?? throw new ArgumentNullException(nameof(deliveryOrderService));
            this._emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("api/orders/{orderId}", Name = "GetOrder")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetOrder(int orderId)
        {
            //await _emailService.SendEmailAsync("daniakroos8@gmail.com", "Test", "Test");
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

            return deliveryOrder == null ? Ok(_mapper.Map<InRestaurantOrderDTO>(inRestaurantOrder)) : Ok(_mapper.Map<DeliveryOrderDTO>(deliveryOrder));
        }

        [HttpPost("api/orders/delivery")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<DeliveryOrderDTO>> CreateDeliveryOrder(DeliveryOrderForCreationDTO deliveryOrderForCreation)
        {
            var finalDeliveryOrder = _mapper.Map<DeliveryOrder>(deliveryOrderForCreation);
            var addedDeliveryOrder = await _deliveryOrderService.AddOrderAsync(finalDeliveryOrder);
            await _deliveryOrderService.SaveChangesAsync();
            var deliveryOrderToReturn = _mapper.Map<DeliveryOrderDTO>(addedDeliveryOrder);

            await _emailService.SendEmailAsync("gontar.viktor@lll.kpi.ua", 
                "Order Number" + deliveryOrderToReturn.OrderId, ParserOfMessage.ParseToMessage(addedDeliveryOrder));
            return CreatedAtRoute("GetOrder", new { deliveryOrderToReturn.OrderId }, deliveryOrderToReturn);
        }

        [HttpPost("api/orders/inrestaurant")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<InRestaurantOrderDTO>> CreateInRestaurantOrder(InResataurantOrderForCreationDTO inResataurantOrderForCreation)
        {
            var finalOrder = _mapper.Map<InRestaurantOrder>(inResataurantOrderForCreation);
            var addedOrder = await _inRestaurantOrderService.AddOrderAsync(finalOrder);
            await _inRestaurantOrderService.SaveChangesAsync();
            var orderToReturn = _mapper.Map<InRestaurantOrderDTO>(addedOrder);

            await _emailService.SendEmailAsync("daniakroos8@gmail.com",
                "Order Number" + orderToReturn.OrderId, ParserOfMessage.ParseToMessage(addedOrder));
            return CreatedAtRoute("GetOrder", new { orderToReturn.OrderId }, orderToReturn);
        }

        [HttpGet("api/orders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<OrderDTO>> GetOrders()
        {
            List<DeliveryOrder> deliveryOrders = (List<DeliveryOrder>)await _deliveryOrderService.GetOrdersAsync();
            List<InRestaurantOrder> inRestaurantOrders = (List<InRestaurantOrder>)await _inRestaurantOrderService.GetOrdersAsync();
            List<Order> orders = deliveryOrders.ConvertAll(order => (Order)order);
            orders.AddRange(inRestaurantOrders.ConvertAll(order => (Order)order));
            return Ok(_mapper.Map<IEnumerable<OrderDTO>>(orders));  
        }

        [HttpDelete("api/orders/{orderId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteOrder(int orderId)
        {
            DeliveryOrder? deliveryOrderToDelete = await _deliveryOrderService.GetOrderAsync(orderId);
            InRestaurantOrder? inRestaurantOrderToDelete = null;
            if (deliveryOrderToDelete == null)
            {
                inRestaurantOrderToDelete = await _inRestaurantOrderService.GetOrderAsync(orderId);
            }
            if (inRestaurantOrderToDelete != null)
            {
                _inRestaurantOrderService.DeleteOrder(inRestaurantOrderToDelete);
            }
            else if (deliveryOrderToDelete != null)
            {
                _deliveryOrderService.DeleteOrder(deliveryOrderToDelete);
            }
            else
            {
                return NotFound();
            }
            await _deliveryOrderService.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("api/orders")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAllOrders()
        {
            await _deliveryOrderService.DeleteAllOrders();
            await _inRestaurantOrderService.DeleteAllOrders();
            await _deliveryOrderService.SaveChangesAsync();
            return NoContent();
        }
    }
}
