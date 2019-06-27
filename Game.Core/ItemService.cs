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

        //Add 
        public bool Add(Item item)
        {
            bool result = false;
            var chk = itemRepository.GetById(item.Id);
            if (chk == null)
            {
                itemRepository.Add(item);
                result = true;
            }
            else
            {
                // to do something
            }
                return result;
        }

        //Delete
        public bool Delete(int id)
        {
            bool result = false;
            var chk = itemRepository.GetById(id);

            if (chk == null)
            {
                //to do something
            }
            else
            {
                itemRepository.Remove(chk);
                result = true;
            }
            return result;
         }
        //Detail
        public Item Query(int id)
        {
            var item = itemRepository.Find(x => x.Id == id).SingleOrDefault();
            return item;
        }

        //Update
        public bool Update(Item item)
        {
            bool result = false;
            var chk = itemRepository.GetById(item.Id);
            if (chk == null)
            {
                //to do something
            }
            else
            {
                itemRepository.Update(item);
                result  = true;
            }
            return result;
        }

    }
}