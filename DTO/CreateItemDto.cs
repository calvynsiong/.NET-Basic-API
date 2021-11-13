namespace NetApi2.DTO
{
    public record CreateItemDto
    {
        public string Name { get; init; }
        public decimal Price { get; init; }

    }
}
