using NetApi2.DTO;
using NetApi2.Entities;

namespace NetApi2
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto { Id = item.Id, Name = item.Name, CreatedDate = item.CreatedDate, Price = item.Price };
        }
    }


}

