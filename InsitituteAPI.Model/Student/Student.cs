namespace InstituteAPI.Models.Student
{
    public class Student
    {
        public string StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string MobileNumber { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string FatherFirstName { get; set; }
        public string FatherLastName { get; set; }
        public string FatherMobileNumber { get; set; }
        public string MotherFirstName { get; set; }
        public string MotherLastName { get; set; }
        public string MotherMobileNumber { get; set; }
        public string StudentClassRoomName { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }
        public string Remarks { get; set; }

        // public string Photo { get; set; }
        public bool AvailingTransport { get; set; }
        public bool AvailingSchool { get; set; }
        public bool AvailingHostel { get; set; }
        public bool Migrated { get; set; }
        public bool IsActive { get; set; }
    }
}
