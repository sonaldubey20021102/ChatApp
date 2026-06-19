namespace chat.Entity
{
    public class Message
    {
        public int Id { get; set; }
        public required string MessageTxt { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int AddedBy { get; set; }
    }
}
