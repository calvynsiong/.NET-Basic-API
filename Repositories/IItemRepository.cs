﻿using NetApi2.Entities;

namespace NetApi2.Repositories
{
    public interface IItemRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}