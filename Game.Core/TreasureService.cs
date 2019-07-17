using Game.Common.Entities;
using Game.Common.Interfaces;
using Game.Dal;
using System.Collections.Generic;
using System.Linq;

namespace Game.Core
{
    public class TreasureService
    {
        ITreasureRepository treasureRepository;
        public TreasureService()
        {
            treasureRepository = new TreasureRepository();
        }
        //Read
        public IEnumerable<Treasure> GetAll()
        {
            var result = treasureRepository.FindAll();
            return result;
        }

        //Add 
        public bool Add(Treasure treasure)
        {
            bool result = false;
            var chk = treasureRepository.GetById(treasure.Id);
            if (chk == null)
            {
                treasureRepository.Add(treasure);
                result = true;
            }
            return result;
        }

        //Delete
        public bool Delete(int id)
        {
            bool result = false;
            var chk = treasureRepository.GetById(id);

            if (chk == null)
            {
                //to do something
            }
            else
            {
                treasureRepository.Remove(chk);
                result = true;
            }
            return result;
        }
        //Detail
        public Treasure Query(int id)
        {
            var treasure = treasureRepository.Find(x => x.Id == id).SingleOrDefault();
            return treasure;
        }

        //Update
        public bool Update(Treasure treasure)
        {
            bool result = false;
            var chk = treasureRepository.GetById(treasure.Id);
            if (chk == null)
            {
                //to do something
            }
            else
            {
                treasureRepository.Update(treasure);
                result = true;
            }
            return result;
        }


        //Sql
     

        public List<MonsterItem> QueryName()
        {
            var item = treasureRepository.QueryNameBySql("SELECT t.ID ,m.name, i.name From Treasure t, Monster m, Item i WHERE m.ID = t.MonsterID and i.ID = t.ItemID; ");

            return item.ToList();

        }
     }
}