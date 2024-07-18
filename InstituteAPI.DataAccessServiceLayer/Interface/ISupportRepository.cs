using InstituteAPI.Models.Support;

namespace InstituteAPI.DataAccessServiceLayer.Interface
{
    public interface ISupportRepository
    {
        public int SetSupport(Support support);
    }
}
