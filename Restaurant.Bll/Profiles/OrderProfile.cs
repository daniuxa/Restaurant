﻿using AutoMapper;
using Restaurant.Bll.Models.ClientDTOs;
using Restaurant.Bll.Models.OrderDTOs;
using Restaurant.Bll.Models.OrderDTOs.DeliveryOrderDTOs;
using Restaurant.Bll.Models.OrderDTOs.InRestaurantOrderDTOs;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDTO>();

            CreateMap<DeliveryOrder, DeliveryOrderDTO>();
            CreateMap<DeliveryOrderForCreationDTO, DeliveryOrder>();

            CreateMap<InResataurantOrderForCreationDTO, InRestaurantOrder>();
            CreateMap<InRestaurantOrder, InRestaurantOrderDTO>();

        }
    }
}
