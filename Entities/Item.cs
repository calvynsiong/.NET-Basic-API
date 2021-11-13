namespace NetApi2.Entities
{
        public class Item
        {
            public Guid Id { get; init; }
            public string? Name { get; init; }
            public decimal Price { get; init; }

            public DateTimeOffset CreatedDate { get; init; }
        }
    
}
