using AutoMapper;
using Restaurant.Bll.Models.DrinkDTOs;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.CustomMappers
{
    public static class DrinkMapper
    {
        public static IDictionary<string, IEnumerable<DrinkForListDTO>> MapDictionary(IMapper _mapper, IDictionary<string, IEnumerable<Drink>> notMappedDictionary)
        {
            IDictionary<string, IEnumerable<DrinkForListDTO>> mappedDictionary = new Dictionary<string, IEnumerable<DrinkForListDTO>>();
            foreach (var notMapped in notMappedDictionary)
            {
                mappedDictionary.Add(notMapped.Key, _mapper.Map<IEnumerable<DrinkForListDTO>>(notMapped.Value));
            }
            return mappedDictionary;
        }
    }
}
