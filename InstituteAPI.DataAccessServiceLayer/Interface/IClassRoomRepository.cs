using InstituteAPI.Models.Class;
using InstituteAPI.Models.ClassRoom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.DataAccessServiceLayer.Interface
{
    public interface IClassRoomRepository
    {
        public List<ClassRoom> GetActiveClassRoom();
        public int SetClassRoom(ClassRoom classRoom);
        public List<Class> GetActiveClass();
        public List<ClassRoomType> GetActiveClassRoomType();
        public void DeleteClassRoom(int classRoomId);
        public ClassRoom GetClassRoomByClassRoomId(int classRoomId);
        public int UpdateClassRoom(ClassRoom classRoom);
    }
}
