using Application.Commands.ViewModels;
using Application.IRepositories;
using AutoMapper;
using Application.IServices;

namespace Application.Services
{
    public class UsersAddressService : IUsersAddressService
    {
        private readonly IUsersAddressRepository _repository;
        private readonly IMapper _mapper;

        public UsersAddressService(IUsersAddressRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UsersAddressViewModel?> GetByIdAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<UsersAddressViewModel>(entity);
        }

        public async Task<IEnumerable<UsersAddressViewModel>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<UsersAddressViewModel>>(entities);
        }

        public async Task<UsersAddressViewModel> AddAsync(UsersAddressViewModel viewModel)
        {
            var entity = _mapper.Map<Model.Entities.UsersAddress>(viewModel);
            var result = await _repository.AddAsync(entity);
            return _mapper.Map<UsersAddressViewModel>(result);
        }

        public async Task<UsersAddressViewModel> UpdateAsync(UsersAddressViewModel viewModel)
        {
            var entity = _mapper.Map<Model.Entities.UsersAddress>(viewModel);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<UsersAddressViewModel>(result);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
