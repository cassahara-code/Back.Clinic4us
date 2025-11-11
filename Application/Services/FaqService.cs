using Application.DTOs.Requests;
using Application.DTOs.Responses;
using Application.IRepositories;
using Application.IServices;
using Domain.Entities;
using AutoMapper;

namespace Application.Services
{
    public class FaqService : IFaqService
    {
        private readonly IFaqRepository _faqRepository;
        private readonly IMapper _mapper;

        public FaqService(IFaqRepository faqRepository, IMapper mapper)
        {
            _faqRepository = faqRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FaqResponse>> GetAllAsync()
        {
            try
            {
                var faqs = await _faqRepository.GetAllAsync();
                return _mapper.Map<IEnumerable<FaqResponse>>(faqs);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<FaqResponse?> GetByIdAsync(Guid id)
        {
            var faq = await _faqRepository.GetByIdAsync(id);
            return _mapper.Map<FaqResponse>(faq);
        }

        public async Task<FaqResponse> CreateAsync(CreateFaqRequest request)
        {
            var entity = _mapper.Map<Faq>(request);
            entity.Id = Guid.NewGuid();
            entity.CreatedDate = DateTime.UtcNow;
            entity.Active = true;
            var created = await _faqRepository.AddAsync(entity);
            return _mapper.Map<FaqResponse>(created);
        }

        public async Task<FaqResponse> UpdateAsync(UpdateFaqRequest request)
        {
            var entity = await _faqRepository.GetByIdAsync(request.Id.Value!);
            if (entity == null) throw new Exception("Faq not found");
            entity.Question = request.Question;
            entity.Answer = request.Answer;
            entity.FaqType = request.FaqType;
            entity.ModifiedDate = DateTime.UtcNow;
            var updated = await _faqRepository.UpdateAsync(entity);
            return _mapper.Map<FaqResponse>(updated);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _faqRepository.DeleteAsync(id);
        }
    }
}