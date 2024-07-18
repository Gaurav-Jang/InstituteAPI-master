using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.DataAccessServiceLayer.Interface;
using InstituteAPI.Models.Class;
using InstituteAPI.Models.ClassRoom;
using InstituteAPI.Models.ClassRoomName;

namespace InstituteAPI.BusinessServiceLayer.Services
{
    public class ClassRoomService : IClassRoomService
    {
        readonly IClassRoomRepository _classRoomRepository;
        private object _classRepository;
        public ClassRoomService(IClassRoomRepository userRepo)
        {
            _classRoomRepository = userRepo;
        }
        public List<ClassRoom> GetActiveClassRoom()
        {
            return _classRoomRepository.GetActiveClassRoom();
        }
        public int SetClassRoom(ClassRoom classRoom)
        {
            return _classRoomRepository.SetClassRoom(classRoom);
        }
        public List<Class> GetActiveClass()
        {
            return _classRoomRepository.GetActiveClass();
        }
        public List<ClassRoomName> GetActiveClassRoomName()
        {
            return _classRoomRepository.GetActiveClassRoomName();
        }
        public List<ClassRoomType> GetActiveClassRoomType()
        {
            return _classRoomRepository.GetActiveClassRoomType();
        }
        public void DeleteClassRoom(int classRoomId)
        {
            _classRoomRepository.DeleteClassRoom(classRoomId);
        }
        public ClassRoom GetClassRoomByClassRoomId(int classRoomId)
        {
            return _classRoomRepository.GetClassRoomByClassRoomId(classRoomId);
        }
        public int UpdateClassRoom(ClassRoom classRoom)
        {
            return _classRoomRepository.UpdateClassRoom(classRoom);
        }

        //CheckDuplicateClassroom
        public int CheckDuplicateClassRoom(ClassRoom classRoom)
        {
            return _classRoomRepository.CheckDuplicateClassRoom(classRoom);
        }

    }
}
