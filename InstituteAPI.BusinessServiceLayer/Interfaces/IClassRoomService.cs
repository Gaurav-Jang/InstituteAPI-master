using InstituteAPI.BusinessServiceLayer.Services;
using InstituteAPI.Models.Class;
using InstituteAPI.Models.ClassRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteAPI.BusinessServiceLayer.Interfaces
{
    public interface IClassRoomService
    {
        public List<ClassRoom> GetActiveClassRoom();
        public int SetClassRoom(ClassRoom classRoom);
        public List<Class> GetActiveClass();
        public List<ClassRoomType> GetActiveClassRoomType();
        public void DeleteClassRoom(int classRoomId);
        // public List<ClassRoom> EditClassRoom(int classRoomId);
    }
}
