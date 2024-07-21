using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.Models.FeesPayment;

namespace InstituteAPI.BusinessServiceLayer.Services
{
    public class FeePaymentService : IFeePaymentService
    {
        readonly IFeePaymentRepository _feePaymentRepository;
        public FeePaymentService(IFeePaymentRepository userRepo)
        {
            _feePaymentRepository = userRepo;
        }
        public List<FeePayment> GetActiveFeesPayment()
        {
            return _feePaymentRepository.GetActiveFeesPayment();
        }
        public int SetFeesPayment(FeePayment feePayment)
        {
            return _feePaymentRepository.SetFeesPayment(feePayment);
        }
        public void DeleteFeesPayment(int feePaymentId)
        {
            _feePaymentRepository.DeleteFeesPayment(feePaymentId);
        }
        public FeePayment GetFeesPaymentByFeesPaymentId(int feePaymentId)
        {
            return _feePaymentRepository.GetFeesPaymentByFeesPaymentId(feePaymentId);
        }
        public int UpdateFeesPayment(FeePayment feePayment)
        {
            return _feePaymentRepository.UpdateFeesPayment(feePayment);
        }

        //CheckDuplicateFeesPayment
        public int CheckDuplicateFeesPayment(FeePayment feePayment)
        {
            return _feePaymentRepository.CheckDuplicateFeesPayment(feePayment);
        }

    }
}
