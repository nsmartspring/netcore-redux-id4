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
            CreateMap<CategoryDto, Category>();

            CreateMap<ProductDto, Product>()
             .ForMember(d => d.ImageUrl, t => t.ToString());
            CreateMap<UserDto, User>();


            CreateMap<RatingDto, Rating>();


            CreateMap<CartDto, Cart>();


            CreateMap<OrderDto, Order>();


            CreateMap<Address, AddressDto>();
            

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
