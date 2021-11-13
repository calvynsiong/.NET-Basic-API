using System.ComponentModel.DataAnnotations;

namespace NetApi2.DTO
{
    public class UpdateItemDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}
