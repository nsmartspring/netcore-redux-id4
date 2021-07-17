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
        }

        private void FromDataAccessorLayer()
        {
            CreateMap<Category, CategoryDto>();
        }
    }
}
