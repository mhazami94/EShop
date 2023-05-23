namespace Identity.Domain.SeedWork.Event
{
    public record class StoredEvent : DomainEvent
    {
        public Guid Id { get; set; }
        public string Payload { get; set; }
        public DateTime? ProcessedAt { get; set; }

        public StoredEvent(DomainEvent @event, string payload)
        {
            Id = Guid.NewGuid();
            Payload = payload;
            MessageType = @event.MessageType;
            AggregateId = @event.AggregateId;
        }

        public void SetProcessedAt(DateTime? date)
        {
            if (date == null)
                throw new ArgumentNullException(nameof(date));

            ProcessedAt = date;
        }

        //EF constructor
        protected StoredEvent() { }
    }
}
