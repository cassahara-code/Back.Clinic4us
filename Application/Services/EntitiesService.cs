using Application.DTOs.Requests;
using Application.DTOs.Responses;
using Application.IRepositories;
using Application.IServices;
using AutoMapper;
using Model.Entities;

namespace Application.Services
{
    public class EntitiesService : IEntitiesService
    {
        private readonly IEntitiesRepository _repository;
        private readonly IMapper _mapper;

        public EntitiesService(IEntitiesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EntityResponse>> GetAllAsync()
        {
            var list = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<EntityResponse>>(list);
        }

        public async Task<EntityResponse?> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<EntityResponse>(entity);
        }

        public async Task<EntityResponse> CreateAsync(CreateEntityRequest request, Guid creator)
        {
            var entity = _mapper.Map<Entities>(request);
            entity.Creator = creator;
            entity.CreatedDate = DateTime.UtcNow;

            var result = await _repository.AddAsync(entity);
            return _mapper.Map<EntityResponse>(result);
        }

        public async Task<EntityResponse> UpdateAsync(UpdateEntityRequest request, Guid updater)
        {
            var existing = await _repository.GetByIdAsync(request.Id);
            if (existing == null)
                throw new ArgumentException($"Entidade com ID {request.Id} não encontrada");

            var createdAt = existing.CreatedDate;
            var creator = existing.Creator;

            _mapper.Map(request, existing);

            existing.CreatedDate = createdAt;
            existing.Creator = creator;
            existing.ModifiedDate = DateTime.UtcNow;

            var result = await _repository.UpdateAsync(existing);
            return _mapper.Map<EntityResponse>(result);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
