using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using Application.DTOs.Requests;
using Application.DTOs.Responses;
using AutoMapper;

namespace Application.Services
{
    public class FaqTypesService : IFaqTypesService
    {
        private readonly IFaqTypesRepository _repository;
        private readonly IMapper _mapper;

        public FaqTypesService(IFaqTypesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FaqTypeResponse>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<FaqTypeResponse>>(entities);
        }

        public async Task<FaqTypeResponse?> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<FaqTypeResponse>(entity);
        }

        public async Task<FaqTypeResponse> AddAsync(CreateFaqTypeRequest request)
        {
            var entity = _mapper.Map<FaqTypes>(request);
            await _repository.AddAsync(entity);
            return _mapper.Map<FaqTypeResponse>(entity);
        }

        public async Task<FaqTypeResponse> UpdateAsync(Guid id, UpdateFaqTypeRequest request)
        {
            var entity = _mapper.Map<FaqTypes>(request);
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return _mapper.Map<FaqTypeResponse>(entity);
        }

        public async Task DeleteAsync(Guid id) =>
            await _repository.DeleteAsync(id);
    }
}