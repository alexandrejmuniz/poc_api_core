using AutoMapper;
using DomainLayer;
using WebInterface.Contracts.Request;
using WebInterface.Contracts.Response;

namespace WebInterface.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductRequest, Product>();

            CreateMap<Product, ProductResponse>()
                .ForMember(po => po.Code, opt => opt.MapFrom(a => a.Id));
        }
    }
}