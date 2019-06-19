using Game.Common.Entities;
using Game.Common.Interfaces;
using Game.Dal;
using System.Collections.Generic;

namespace Game.Core
{
    public class ItemService
    {
        IRepository<Item> itemRepository;

        public ItemService()
        {
            itemRepository = new ItemRepository();
        }
        public IEnumerable<Item> GetAll()
        {
            var result = itemRepository.FindAll();
            return result;
        }
    }
}