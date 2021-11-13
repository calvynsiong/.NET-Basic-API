using Microsoft.AspNetCore.Mvc;
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
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            Console.WriteLine(items);
            return items;
        }
        //Get Request
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);
            if (item is null) return NotFound("Item not found");
            return item;
        }
    }
}
