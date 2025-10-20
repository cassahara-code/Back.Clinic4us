
using Application.Commands.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IFaqService
    {
        Task<IEnumerable<FaqViewModel>> GetAllAsync();
        Task<FaqViewModel?> GetByIdAsync(Guid id);
        Task<FaqViewModel> AddAsync(FaqViewModel viewModel);
        Task<FaqViewModel> UpdateAsync(FaqViewModel viewModel);
        Task<bool> DeleteAsync(Guid id);
    }
}
