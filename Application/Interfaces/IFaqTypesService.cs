using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs.Responses;
using Application.DTOs.Requests;

namespace Application.Interfaces
{
    public interface IFaqTypesService
    {
        Task<IEnumerable<FaqTypeResponse>> GetAllAsync();
        Task<FaqTypeResponse?> GetByIdAsync(Guid id);
        Task<FaqTypeResponse> AddAsync(CreateFaqTypeRequest request);
        Task<FaqTypeResponse> UpdateAsync(Guid id, UpdateFaqTypeRequest request);
        Task DeleteAsync(Guid id);
    }
}