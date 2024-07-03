using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.DataAccessServiceLayer.Repository;
using InstituteAPI.Models.FeeStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.BusinessServiceLayer.Services
{
    public class FeeStructureService : IFeeStructureService
    {
        readonly IFeeStructureRepository _feeStructureRepository;
        public FeeStructureService(IFeeStructureRepository userRepo)
        {
            _feeStructureRepository = userRepo;
        }

        public int SetFeeStructure(FeeStructure feeStructure)
        {
            return _feeStructureRepository.SetFeeStructure(feeStructure);
        }
    }
}
