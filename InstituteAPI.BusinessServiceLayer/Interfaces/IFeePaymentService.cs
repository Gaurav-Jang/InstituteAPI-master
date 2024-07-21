using InstituteAPI.Models.FeesPayment;

namespace InstituteAPI.BusinessServiceLayer.Interfaces
{
    public interface IFeePaymentService
    {
        public List<FeePayment> GetActiveFeesPayment();
        public int SetFeesPayment(FeePayment feePayment);
        public void DeleteFeesPayment(int feePaymentId);
        public FeePayment GetFeesPaymentByFeesPaymentId(int feePaymentId);
        public int UpdateFeesPayment(FeePayment feePayment);
        public int CheckDuplicateFeesPayment(FeePayment feePayment);
    }
}
