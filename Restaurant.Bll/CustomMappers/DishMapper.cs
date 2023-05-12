using AutoMapper;
using Restaurant.Bll.Models.DishDTOs;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.CustomMappers
{
    public static class DishMapper
    {
        public static IDictionary<string, IEnumerable<DishForListDTO>> MapDictionary(IMapper _mapper, IDictionary<string, IEnumerable<Dish>> notMappedDictionary)
        {
            IDictionary<string, IEnumerable<DishForListDTO>> mappedDictionary = new Dictionary<string, IEnumerable<DishForListDTO>>();
            foreach (var notMapped in notMappedDictionary)
            {
                mappedDictionary.Add(notMapped.Key, _mapper.Map<IEnumerable<DishForListDTO>>(notMapped.Value));
            }
            return mappedDictionary;
        }
    }
}
