using Restaurant.Bll.Models.OrderDTOs.DeliveryOrderDTOs;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll
{
    //Temporal variant
    static public class ParserOfMessage
    {
        public static string ParseToMessage(DeliveryOrder deliveryOrderDTO)
        {
            string message = string.Empty;
            message = "Client " + deliveryOrderDTO.Client.FirstName + " "
                + deliveryOrderDTO.Client.LastName + " Address: " + deliveryOrderDTO.Address + " Phone: " + deliveryOrderDTO.Client.PhoneNumber
                + " made an order on " + deliveryOrderDTO.DateOfOrder
                + " and positions: \n";
            string positionsInOrder = string.Empty;

            foreach (var item in deliveryOrderDTO.PositionsInOrders)
            {
                positionsInOrder +=
                    "Position number " + item.MenuPostionId + " Quantity " + item.Quantity + " Comment " + item.Comment + "\n";
            }
            message += positionsInOrder;

            return message;
        }

        public static string ParseToMessage(InRestaurantOrder inRestaurantOrderDTO)
        {
            string message = string.Empty;
            message = "Client " + inRestaurantOrderDTO.Client.FirstName + " "
                + inRestaurantOrderDTO.Client.LastName + " Table Number: " + inRestaurantOrderDTO.TableNumber + " Phone: " + inRestaurantOrderDTO.Client.PhoneNumber
                + " made an order on " + inRestaurantOrderDTO.DateOfOrder
                + " and positions: \n";
            string positionsInOrder = string.Empty;

            foreach (var item in inRestaurantOrderDTO.PositionsInOrders)
            {
                positionsInOrder +=
                    "Position number " + item.MenuPostionId + " Quantity " + item.Quantity + " Comment " + item.Comment + "\n";
            }
            message += positionsInOrder;

            return message;
        }
    }
}
