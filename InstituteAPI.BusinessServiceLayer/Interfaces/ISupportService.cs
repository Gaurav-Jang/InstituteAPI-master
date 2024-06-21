using InstituteAPI.BusinessServiceLayer.Services;
using InstituteAPI.Models.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.BusinessServiceLayer.Interfaces
{
    public interface ISupportService
    {
        public int SetSupport(Support support);
    }
}
