namespace Application.Models
{
    public class Search
    {
        public class SearcMeetingRequest
        { 
            public string TeamName { get; set; }
        }
        public class SearchEventRequest
        {
            public string EventName { get; set; }
        }
    }
}
