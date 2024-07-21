namespace InstituteAPI.Models.FeesPayment
{
    public class FeePayment
    {
        public string FeesPaymentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentClassRoomName { get; set; }
        public string Dob { get; set; }
        public string FatherFirstName { get; set; }
        public bool AvailingTransport { get; set; }
        public bool AvailingSchool { get; set; }
        public bool AvailingHostel { get; set; }
        public string RegistrationFees { get; set; }
        public string AdmissionFees { get; set; }
        public string WelcomeKit { get; set; }
        public string TuitionFees { get; set; }
        public string SchoolFees { get; set; }
        public string ExamFees { get; set; }
        public string MigrationCharges { get; set; }
        public string SubTotal { get; set; }
        public string Discount { get; set; }
        public string TotalAmount { get; set; }
        public bool IsActive { get; set; }
    }
}