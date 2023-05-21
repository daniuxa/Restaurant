using AutoMapper;
using Restaurant.Bll.Models.OrderDTOs.DeliveryOrderDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Profiles
{
    public class MessageProfile : Profile
    {
        public MessageProfile()
        {
            /*CreateMap<DeliveryOrderDTO, string>()
                .ForMember(x => x, 
                member => member
                .MapFrom(source => "Client " + source.Client.FirstName + " " 
                + source.Client.LastName + " Address: " + source.Address + " Phone: " + source.Client.PhoneNumber 
                +"made an order on " + source.DateOfOrder 
                + "and order: \n" + source.PositionsInOrders.);*/
        }
    }
}
