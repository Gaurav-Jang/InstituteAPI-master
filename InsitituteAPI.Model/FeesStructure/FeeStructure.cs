namespace InstituteAPI.Models.FeeStructure
{
    public class FeeStructure
    {
        public string FeeStructureId { get; set; }
        public string StudentClassRoomNames { get; set; }
        public string RegistrationFees { get; set; }
        public string AdmissionFees { get; set; }
        public string TuitionFees { get; set; }
        public string WelcomeKit { get; set; }
        public string SchoolFees { get; set; }
        public string ExamFees { get; set; }
        public string MigrationCharges { get; set; }
        public bool IsActive { get; set; }
    }
}