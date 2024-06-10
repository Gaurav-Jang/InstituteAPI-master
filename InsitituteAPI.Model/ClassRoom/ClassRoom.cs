namespace InstituteAPI.Models.ClassRoom
{
    public class ClassRoom    
    {
        public string ClassRoomId { get; set; }
        public string ClassRoomName { get; set; }
        public string Class { get; set; }
        public string ClassRoomType { get; set; }
        public int Price { get; set; }
        public bool IsActive { get; set; }
    }
}
