using InstituteAPI.Models.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.DataAccessServiceLayer.Interface
{
    public interface ISupportRepository
    {
        public int SetSupport(Support support);
    }
}
