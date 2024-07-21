namespace InstituteAPI.DataAccessServiceLayer
{
    public static class Constants
    {
        public class StoreProcedures
        {
            // get
            public const string GetActiveClassRoom = "GetActiveClassRoom";
            public const string GetActiveClass = "GetActiveClass";
            public const string GetActiveClassRoomName = "GetActiveClassRoomName";
            public const string GetActiveClassRoomType = "GetActiveClassRoomType";
            public const string GetActiveStudent = "GetActiveStudent";
            public const string GetStudentByStudentId = "GetStudentByStudentId";
            public const string GetActiveFeeStructure = "GetActiveFeeStructure";
            public const string GetActiveFeesPayment = "GetActiveFeePayment";
            public const string GetClassRoomByClassRoomId = "GetClassRoomByClassRoomId";
            public const string GetFeeStructureByFeeStructureId = "GetFeeStructureByFeeStructureId";
            public const string GetFeesPaymentByFeesPaymentId = "GetFeesPaymentByFeesPaymentId";
            public const string GetFeeStructureByClassRoom = "GetFeeStructureByClassRoom";

            // set
            public const string SetClassRoom = "SetClassRoom";
            public const string SetStudent = "SetStudent";
            public const string SetSupport = "SetSupport";
            public const string SetFeeStructure = "SetFeeStructure";
            public const string SetFeesPayment = "SetFeesPayment";

            // update
            public const string UpdateClassRoom = "UpdateClassRoom";
            public const string UpdateStudent = "UpdateStudent";
            public const string UpdateFeeStructure = "UpdateFeeStructure";
            public const string UpdateFeesPayment = "UpdateFeesPayment";

            // delete
            public const string DeleteClassRoom = "DeleteClassRoom";
            public const string DeleteStudent = "DeleteStudent";
            public const string DeleteFeeStructure = "DeleteFeeStructure";
            public const string DeleteFeesPayment = "DeleteFeePayment";

            //CheckDuplicateClassroom
            public const string CheckDuplicateClassRoom = "CheckDuplicateClassRoom";
            public const string CheckDuplicateStudent = "CheckDuplicateStudent";
            public const string CheckDuplicateFeeStructure = "CheckDuplicateFeeStructure";
            public const string CheckDuplicateFeesPayment = "CheckDuplicateFeePayment";
        }
        public class Parameters
        {
            // classroom
            public const string inClassRoomId = "inClassRoomId";
            public const string inClassRoomName = "inClassRoomName";
            public const string inClass = "inClass";
            public const string inClassRoomType = "inClassRoomType";
            public const string inPrice = "inPrice";

            // edit classroom
            public const string inGetClassRoomByClassRoomId = "inGetClassRoomByClassRoomId";

            // student
            public const string inStudentId = "inStudentId";
            public const string inStudentFirstName = "inStudentFirstName";
            public const string inStudentLastName = "inStudentLastName";
            public const string inMobileNumber = "inMobileNumber";
            public const string inGender = "inGender";
            public const string inDob = "inDob";
            public const string inFatherFirstName = "inFatherFirstName";
            public const string inFatherLastName = "inFatherLastName";
            public const string inFatherMobileNumber = "inFatherMobileNumber";
            public const string inMotherFirstName = "inMotherFirstName";
            public const string inMotherLastName = "inMotherLastName";
            public const string inMotherMobileNumber = "inMotherMobileNumber";
            public const string inStudentClassRoomName = "inStudentClassRoomName";
            public const string inAddress = "inAddress";
            public const string inCategory = "inCategory";
            public const string inRemarks = "inRemarks";
            public const string inPhoto = "inPhoto";
            public const string inAvailingTransport = "inAvailingTransport";
            public const string inAvailingSchool = "inAvailingSchool";
            public const string inAvailingHostel = "inAvailingHostel";
            public const string inMigrated = "inMigrated";
            public const string inIsActive = "inIsActive";

            // support
            public const string inSupportId = "inSupportId";
            public const string inFullName = "inFullName";
            public const string inEmail = "inEmail";
            public const string inSubject = "inSubject";
            public const string inMessage = "inMessage";

            // AddFeeStructure
            public const string inFeeStructureId = "inFeeStructureId";
            public const string inStudentClassRoomNames = "inStudentClassRoomNames";
            public const string inRegistrationFees = "inRegistrationFees";
            public const string inAdmissionFees = "inAdmissionFees";
            public const string inTuitionFees = "inTuitionFees";
            public const string inWelcomeKit = "inWelcomeKit";
            public const string inSchoolFees = "inSchoolFees";
            public const string inExamFees = "inExamFees";
            public const string inMigrationCharges = "inMigrationCharges";

            // FeePayment
            public const string inFeePaymentId = "inFeePaymentId";
            public const string inFeeStudentFirstName = "inFeeStudentFirstName";
            public const string inFeeDob = "inFeeDob";
            public const string inFeeFatherFirstName = "inFeeFatherFirstName";
            public const string inFeeStudentClassRoomName = "inFeeStudentClassRoomName";
            public const string inFeeAvailingTransport = "inFeeAvailingTransport";
            public const string inFeeAvailingSchool = "inFeeAvailingSchool";
            public const string inFeeAvailingHostel = "inFeeAvailingHostel";
            public const string inFeeRegistrationFees = "inFeeRegistrationFees";
            public const string inFeeAdmissionFees = "inFeeAdmissionFees";
            public const string inFeeTuitionFees = "inFeeTuitionFees";
            public const string inFeeWelcomeKit = "inFeeWelcomeKit";
            public const string inFeeSchoolFees = "inFeeSchoolFees";
            public const string inFeeExamFees = "inFeeExamFees";
            public const string inFeeMigrationCharges = "inFeeMigrationCharges";
        }
    }
}
