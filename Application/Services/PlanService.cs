using Application.Commands.ViewModels;
using Application.IRepositories;
using AutoMapper;
using Application.IServices;

namespace Application.Services
{
    public class PlanService : IPlanService
    {
        private readonly IPlanRepository _repository;
        private readonly IMapper _mapper;

        public PlanService(IPlanRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PlanViewModel?> GetByIdAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;
            return _mapper.Map<PlanViewModel>(entity);
        }

        public async Task<IEnumerable<PlanViewModel>> GetAllAsync()
        {
            var entities = await _repository.GetAllWithBenefitsAsync();
            return _mapper.Map<IEnumerable<PlanViewModel>>(entities);
        }

        public async Task<PlanViewModel> AddAsync(PlanViewModel viewModel)
        {
            var entity = _mapper.Map<Model.Entities.Plans>(viewModel);
            var result = await _repository.AddAsync(entity);
            return _mapper.Map<PlanViewModel>(result);
        }

        public async Task<PlanViewModel> UpdateAsync(PlanViewModel viewModel)
        {
            var entity = _mapper.Map<Model.Entities.Plans>(viewModel);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PlanViewModel>(result);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
