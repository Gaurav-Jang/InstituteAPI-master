using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.Models.FeeStructure;

namespace InstituteAPI.BusinessServiceLayer.Services
{
    public class FeeStructureService : IFeeStructureService
    {
        readonly IFeeStructureRepository _feeStructureRepository;
        public FeeStructureService(IFeeStructureRepository userRepo)
        {
            _feeStructureRepository = userRepo;
        }
        public List<FeeStructure> GetActiveFeeStructure()
        {
            return _feeStructureRepository.GetActiveFeeStructure();
        }
        public List<FeeStructure> GetFeeStructureByClassRoom(string classRoomName)
        {
            return _feeStructureRepository.GetFeeStructureByClassRoom(classRoomName);
        }
        public int SetFeeStructure(FeeStructure feeStructure)
        {
            return _feeStructureRepository.SetFeeStructure(feeStructure);
        }
        public void DeleteFeeStructure(int feeStructureId)
        {
            _feeStructureRepository.DeleteFeeStructure(feeStructureId);
        }
        public FeeStructure GetFeeStructureByFeeStructureId(int feeStructureId)
        {
            return _feeStructureRepository.GetFeeStructureByFeeStructureId(feeStructureId);
        }
        public int UpdateFeeStructure(FeeStructure feeStructure)
        {
            return _feeStructureRepository.UpdateFeeStructure(feeStructure);
        }

        //CheckDuplicateFeeStructure
        public int CheckDuplicateFeeStructure(FeeStructure feeStructure)
        {
            return _feeStructureRepository.CheckDuplicateFeeStructure(feeStructure);
        }
    }
}
