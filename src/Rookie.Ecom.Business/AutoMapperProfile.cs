using Rookie.Ecom.Contracts.Dtos;
using Rookie.Ecom.DataAccessor.Entities;

namespace Rookie.Ecom.Business
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            FromDataAccessorLayer();
            FromPresentationLayer();
        }

        private void FromPresentationLayer()
        {
            CreateMap<CategoryDto, Category>()
               .ForMember(d => d.ImageUrl, t => t.Ignore());
            CreateMap<ProductDto, Product>()
             .ForMember(d => d.ImageUrl, t => t.ToString());
            CreateMap<UserDto, User>()
           .ForMember(d => d.Id, t => t.Ignore());
            CreateMap<RatingDto, Rating>()
           .ForMember(d => d.Id, t => t.Ignore());
            CreateMap<CartDto, Cart>()
          .ForMember(d => d.Id, t => t.Ignore());
            CreateMap<OrderDto, Order>()
          .ForMember(d => d.Id, t => t.Ignore());
            CreateMap<Address, AddressDto>()
            .ForMember(d => d.Id, t => t.Ignore());

        }

        private void FromDataAccessorLayer()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductDto>();
            CreateMap<User, UserDto>();
            CreateMap<Rating, RatingDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<Cart, CartDto>();
            CreateMap<Address, AddressDto>();

        }
    }
}
