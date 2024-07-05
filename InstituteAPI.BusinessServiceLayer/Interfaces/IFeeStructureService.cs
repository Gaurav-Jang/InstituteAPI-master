using InstituteAPI.BusinessServiceLayer.Services;
using InstituteAPI.Models.FeeStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.BusinessServiceLayer.Interfaces
{
    public interface IFeeStructureService
    {
        public List<FeeStructure> GetActiveFeeStructure();
        public int SetFeeStructure(FeeStructure feeStructure);
        public void DeleteFeeStructure(int feeStructureId);
        public FeeStructure GetFeeStructureByFeeStructureId(int feeStructureId);
        public int UpdateFeeStructure(FeeStructure feeStructure);
        public int CheckDuplicateFeeStructure(FeeStructure feeStructure);
    }
}

