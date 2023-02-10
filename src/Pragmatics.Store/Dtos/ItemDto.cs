namespace Pragmatics.Store.Dtos
{
    public class ItemDto
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public DateTimeOffset CreatedDate { get; set; }
    }
}