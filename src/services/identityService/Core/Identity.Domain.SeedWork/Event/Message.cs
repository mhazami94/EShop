namespace Identity.Domain.SeedWork.Event
{
    public abstract record class Message
    {
        public string? MessageType { get; set; }
        public Guid AggregateId { get; set; }

        protected Message()
        {
            MessageType = GetType().FullName;
        }
    }
}
