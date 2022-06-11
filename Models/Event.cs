namespace tracerapi.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Sujet { get; set; } = string.Empty;
       public DateTime DateStart { get; set; } = DateTime.Now;
       public DateTime DateEnd { get; set; } = DateTime.Now;
    }
}
