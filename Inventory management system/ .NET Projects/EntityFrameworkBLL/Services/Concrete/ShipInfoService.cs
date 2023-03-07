using AutoMapper;
using EntityFrameworkBLL.DTO.Requests;
using EntityFrameworkBLL.DTO.Responses;
using EntityFrameworkBLL.Services.Abstract;
using EntityFrameworkDAL.Entities;
using EntityFrameworkDAL.Repositories.Abstract;
using EntityFrameworkDAL.UnitOfWork.Abstract;

namespace EntityFrameworkBLL.Services.Concrete
{
    public class ShipInfoService : IShipInfoService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        private readonly IMapper _mapper;
        
        private readonly IShipInfoRepository _shipInfoRepository;

        public ShipInfoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _shipInfoRepository = unitOfWork.ShipInfoRepository;
        }

        private async Task<ShipInfoResponse> ExtendForResponse(ShipInfo shipInfo)
        {
            var response = _mapper.Map<ShipInfo, ShipInfoResponse>(shipInfo);
            throw new NotImplementedException("Implement location using http client");
            // var location = ;
            // response.FullLocation = location.RegionNavigation.Name + ", " +
            //                         location.City + ", " +
            //                         location.LocalAddress;
            return response;
        }

        public async Task<IEnumerable<ShipInfoResponse>> GetAllAsync()
        {
            var shipInfos = await _shipInfoRepository.GetAllAsync();
            var responses = new List<ShipInfoResponse>();
            foreach (var shipInfo in shipInfos)
            {
                var response = await ExtendForResponse(shipInfo);
                responses.Add(response);
            }
            
            return responses;
        }

        public async Task<ShipInfoResponse> GetByIdAsync(int id)
        {
            var shipInfo = await _shipInfoRepository.GetByIdAsync(id);
            return await ExtendForResponse(shipInfo);
        }

        public async Task<int> InsertAsync(ShipInfoPostRequest request)
        {
            var entity = _mapper.Map<ShipInfoPostRequest, ShipInfo>(request);
            await _shipInfoRepository.InsertAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity.Id;
        }

        public async Task UpdateAsync(ShipInfoRequest request)
        {
            var entity = _mapper.Map<ShipInfoRequest, ShipInfo>(request);
            await _shipInfoRepository.UpdateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _shipInfoRepository.DeleteByIdAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
