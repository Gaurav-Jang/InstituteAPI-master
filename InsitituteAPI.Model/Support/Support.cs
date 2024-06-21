namespace InstituteAPI.Models.Support
{
    public class Support
    {
        public string SupportId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsActive { get; set; }
    }
}
