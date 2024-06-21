using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.Models.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.BusinessServiceLayer.Services
{
    public class SupportService : ISupportService
    {
        private readonly ISupportRepository _supportRepository;

        public SupportService(ISupportRepository supportRepository)
        {
            _supportRepository = supportRepository;
        }

        public int SetSupport(Support support)
        {
            return _supportRepository.SetSupport(support);
        }

    }
}