namespace Identity.Application.EventSourcing.StoredEventsData
{
    public record class StoredEventData
    {
        public string Id { get; set; }
        public string Action { get; set; }
        public string Timestamp { get; set; }
    }
}
