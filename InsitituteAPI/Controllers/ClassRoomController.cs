using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.Models.Class;
using InstituteAPI.Models.ClassRoom;
using Microsoft.AspNetCore.Mvc;

namespace InstituteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly ILogger<ClassRoomController> _logger;
        private readonly IClassRoomService _classRoomService;
        public ClassRoomController(ILogger<ClassRoomController> logger, IClassRoomService classRoomService)
        {
            _logger = logger;
            _classRoomService = classRoomService;
        }

        // Get
        [HttpGet]
        [Route("GetActiveClassRoom")]
        public IActionResult GetActiveClassRoom()
        {
            List<ClassRoom> classRooms = _classRoomService.GetActiveClassRoom();
            return Ok(classRooms);
        }

        [HttpGet]
        [Route("GetActiveClass")]
        public IActionResult GetActiveClass()
        {
            List<Class> classDetails = _classRoomService.GetActiveClass();
            return Ok(classDetails);
        }

        [HttpGet]
        [Route("GetActiveClassRoomType")]
        public IActionResult GetActiveClassRoomType()
        {
            List<ClassRoomType> classDetails = _classRoomService.GetActiveClassRoomType();
            return Ok(classDetails);
        }

        // delete
        [HttpGet]
        [Route("DeleteClassRoom")]
        public IActionResult DeleteClassRoom(int classRoomId)
        {
            _classRoomService.DeleteClassRoom(classRoomId);
            return Ok();
        }

        // edit
        [HttpGet]
        [Route("GetClassRoomByClassRoomId")]
        public IActionResult GetClassRoomByClassRoomId(int classRoomId)
        {
            ClassRoom classRoom = _classRoomService.GetClassRoomByClassRoomId(classRoomId);
            return Ok(classRoom);
        }

        // update
        [HttpPost]
        [Route("UpdateClassRoom")]
        public IActionResult UpdateClassRoom([FromBody] ClassRoom classRoom)
        {
            int ClassRoomId = _classRoomService.UpdateClassRoom(classRoom);
            return Ok(ClassRoomId);
        }

        // Post
        [HttpPost]
        [Route("SetClassRoom")]
        public IActionResult SetClassRoom([FromBody] ClassRoom classRoom)
        {
            var data = _classRoomService.CheckDuplicateClassRoom(classRoom);
            if (data > 0)
            {
                return Ok("Class room already exists.");
            }
            else
            {
                int ClassRoomId = _classRoomService.SetClassRoom(classRoom);
                return Ok(ClassRoomId);
            }

        }
    }
}
