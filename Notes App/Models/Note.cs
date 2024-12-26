namespace Notes_App.Models
{
    public class Note
    {
        public required string FileName { get; set; }
        public DateTime LastModified { get; set; }
    }
}
