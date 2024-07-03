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
        public int SetFeeStructure(FeeStructure feeStructure);
    }
}

