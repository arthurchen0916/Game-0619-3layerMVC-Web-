using Game.Common.Entities;
using Game.Common.Interfaces;
using Game.Dal;
using System.Collections.Generic;
using System.Linq;

namespace Game.Core
{
    public class ItemService
    {
        IRepository<Item> itemRepository;

        public ItemService()
        {
            itemRepository = new ItemRepository();
        }
        //Read
        public IEnumerable<Item> GetAll()
        {
            var result = itemRepository.FindAll();
            return result;
        }

        public bool Add(Item item)
        {
            bool result = false;
            var chk = itemRepository.GetById(item.Id);
            if (null == chk)
            {
                itemRepository.Add(item);
                result = true;
            }
            else
            {
                // todo something
            }

            return result;
        }

        public bool Update(Item item)
        {
            bool result = false;
            var chk = itemRepository.GetById(item.Id);
            if (null == chk)
            {
                // todo something
            }
            else
            {
                itemRepository.Update(item);
                result = true;
            }

            return result;
        }

        public bool Remove(int id)
        {
            bool result = false;
            var chk = itemRepository.GetById(id);
            if (null == chk)
            {
                // todo something
            }
            else
            {
                itemRepository.Remove(chk);
                result = true;
            }

            return result;
        }

        public Item Query(int id)
        {
            var item = itemRepository.Find(x => x.Id == id).SingleOrDefault();

            return item;
        }

        public List<Item> QueryByWeight(int weight)
        {
            var item = itemRepository.Find(x => x.Weight > weight).ToList();

            return item;
        }
    }
}