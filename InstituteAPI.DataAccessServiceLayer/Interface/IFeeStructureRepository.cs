using InstituteAPI.Models.FeeStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.DataAccessServiceLayer.Interface
{
    public interface IFeeStructureRepository
    {
        public int SetFeeStructure(FeeStructure feeStructure);
    }
}

