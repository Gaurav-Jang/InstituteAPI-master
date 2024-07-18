using InstituteAPI.Models.Class;
using InstituteAPI.Models.ClassRoom;
using InstituteAPI.Models.ClassRoomName;

namespace InstituteAPI.BusinessServiceLayer.Interfaces
{
    public interface IClassRoomService
    {
        public List<ClassRoom> GetActiveClassRoom();
        public int SetClassRoom(ClassRoom classRoom);
        public List<Class> GetActiveClass();
        public List<ClassRoomName> GetActiveClassRoomName();
        public List<ClassRoomType> GetActiveClassRoomType();
        public void DeleteClassRoom(int classRoomId);
        public ClassRoom GetClassRoomByClassRoomId(int classRoomId);
        public int UpdateClassRoom(ClassRoom classRoom);
        public int CheckDuplicateClassRoom(ClassRoom classRoom);
    }
}
