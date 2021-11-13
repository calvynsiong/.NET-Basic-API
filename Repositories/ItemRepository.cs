using NetApi2.Entities;
namespace NetApi2.Repositories
{

    public class ItemRepository : IItemRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Hamburger", Price = 12.2M, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Pizza", Price = 11.2M, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Sandwich", Price = 12.2M, CreatedDate = DateTimeOffset.UtcNow },
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public void CreateItem(Item newItem)
        {
            items.Add(newItem);
        }
        public void UpdateItem(Item newItem)
        {
            int index = items.FindIndex(existingItem => newItem.Id == existingItem.Id);
            items[index] = newItem;
        }

    }
}
