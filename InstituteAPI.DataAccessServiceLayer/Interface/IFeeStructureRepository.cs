using InstituteAPI.Models.FeeStructure;

namespace InstituteAPI.DataAccessServiceLayer.Interface
{
    public interface IFeeStructureRepository
    {
        public List<FeeStructure> GetActiveFeeStructure();
        public List<FeeStructure> GetFeeStructureByClassRoom(string classRoomName);
        public int SetFeeStructure(FeeStructure feeStructure);
        public void DeleteFeeStructure(int feeStructureId);
        public FeeStructure GetFeeStructureByFeeStructureId(int feeStructureId);
        public int UpdateFeeStructure(FeeStructure feeStructure);
        public int CheckDuplicateFeeStructure(FeeStructure feeStructure);
    }
}

