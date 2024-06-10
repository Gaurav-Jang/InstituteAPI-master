using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.DataAccessServiceLayer
{
    public static class Constants
    {
        public class StoreProcedures
        {
            public const string GetActiveClassRoom = "GetActiveClassRoom";
            public const string GetActiveClass = "GetActiveClass";
            public const string GetActiveClassRoomType = "GetActiveClassRoomType";
            public const string SetClassRoom = "SetClassRoom";
            public const string GetActiveStudent = "GetActiveStudent";
            public const string DeleteClassRoom = "DeleteClassRoom";
            public const string DeleteStudent = "DeleteStudent";
            public const string SetStudent = "setStudent";

            // public static string DeleteStudent { get; internal set; }
            // public const string EditClassRoom = "EditClassRoom";
        }
        public class Parameters
        {
            //classroom
            public const string inClassRoomName = "inClassRoomName";
            public const string inClass = "inClass";
            public const string inClassRoomType = "inClassRoomType";
            public const string inPrice = "inPrice";
            public const string inClassRoomId = "inClassRoomId";

            //student
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
        }
    }
}
