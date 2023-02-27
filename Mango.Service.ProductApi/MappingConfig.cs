using AutoMapper;
using Mango.Service.ProductApi.Models;
using Mango.Service.ProductApi.Models.Dto;

namespace Mango.Service.ProductApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
