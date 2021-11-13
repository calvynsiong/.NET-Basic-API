namespace NetApi2.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public DateTimeOffset CreatedDate { get; set; }
    }

}
