using Application.Commands.ViewModels;
using Application.IRepositories;
using AutoMapper;
using Application.IServices;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UserViewModel?> GetByIdAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<UserViewModel>(entity);
        }

        public async Task<IEnumerable<UserViewModel>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserViewModel>>(entities);
        }

        public async Task<UserViewModel> AddAsync(UserViewModel viewModel)
        {
            var entity = _mapper.Map<Model.Entities.User>(viewModel);
            var result = await _repository.AddAsync(entity);
            return _mapper.Map<UserViewModel>(result);
        }

        public async Task<UserViewModel> UpdateAsync(UserViewModel viewModel)
        {
            var entity = _mapper.Map<Model.Entities.User>(viewModel);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<UserViewModel>(result);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
