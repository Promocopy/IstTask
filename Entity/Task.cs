namespace istTask.Entity
{
    public class Task
    {
        public int Id { get; set; }
        public string? slackName { get; set; }
        public DateTime creationDate { get; set; }
        public DayOfWeek Day { get; set; } = DateTime.Today.DayOfWeek;
        public string? Track { get; set; }
        public int statuscode { get; set; }
    }
}
