using Rookie.Ecom.Contracts;
using Rookie.Ecom.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rookie.Ecom.Business.Interfaces
{
    public interface IRatingService
    {
        Task<IEnumerable<RatingDto>> GetAllAsync();

        Task<PagedResponseModel<RatingDto>> PagedQueryAsync(string name, int page, int limit);

        Task<RatingDto> GetByIdAsync(Guid id);

        Task<RatingDto> AddAsync(RatingDto ratingDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(RatingDto ratingDto);
    }
}
