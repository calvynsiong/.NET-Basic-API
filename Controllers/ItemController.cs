using Microsoft.AspNetCore.Mvc;
using NetApi2.DTO;
using NetApi2.Entities;
using NetApi2.Repositories;
namespace NetApi2.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {
        public readonly IItemRepository repository;

        public ItemController(IItemRepository repository)
        {
            this.repository = repository;
        }
        //Get Request
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = repository.GetItems().Select(item => item.AsDto());
            return items;
        }
        //Get Request
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item = repository.GetItem(id);
            if (item is null) return NotFound("Item not found");
            return item.AsDto();
        }
        //Post Request
        [HttpPost]
        public ActionResult<ItemDto> CreateItem(CreateItemDto newItem)
        {
            Item item = new()
            {
                Id = Guid.NewGuid(),
                Name = newItem.Name,
                Price = newItem.Price,
                CreatedDate = DateTimeOffset.UtcNow,
            };
            repository.CreateItem(item);
            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item.AsDto());
        }
        //Put Request
        [HttpPut("{id}")]
        public ActionResult UpdateItem(Guid id, UpdateItemDto newItem)
        {

            var existingItem = repository.GetItem(id);
            if (existingItem is null) { return NotFound(); }
            existingItem.Name = newItem.Name;
            existingItem.Price = newItem.Price;
            repository.UpdateItem(existingItem);
            return NoContent();
        }


    }
}
