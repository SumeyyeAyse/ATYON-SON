using Atyon.Core;
using Atyon.Core.Models;
using Atyon.Core.Services;

namespace Atyon.Services
{
    public class FacilityService : IFacilityService
    {
        private readonly IUnitOfWork _unitOfWork;
        public FacilityService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Facility>> GetAll()
        {
            return await _unitOfWork.Facilities
                .GetAllAsync();
        }

        public async Task<Facility> CreateFacility(Facility newFacility)
        {
            await _unitOfWork.Facilities.AddAsync(newFacility);
            await _unitOfWork.CommitAsync();
            return newFacility;
        }

        public async Task DeleteFacility(Facility facility)
        {
            _unitOfWork.Facilities.Remove(facility);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateFacility(Facility facilityToBeUpdated, Facility facility)
        {
            facilityToBeUpdated.FacilityName = facility.FacilityName;
           facilityToBeUpdated.FacilityId = facility.FacilityId;

            await _unitOfWork.CommitAsync();
        }

        public async Task<Facility> GetFacilityByCode(int code)
        {
            return await _unitOfWork.Facilities
                .GetByCodeAsync(code);
        }

        public async Task<Facility> GetWithWasteStockByCodeAsync(int code)
        {
            return await _unitOfWork.Facilities
                .GetFacilityWithWasteStockByWasteStockCodeAsync(FacilityId, wasteStockCode);
        }
    }
}
