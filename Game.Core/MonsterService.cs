using Game.Common.Entities;
using Game.Common.Interfaces;
using Game.Dal;
using System.Collections.Generic;
using System.Linq;

namespace Game.Core
{
    public class MonsterService
    {
        IRepository<Monster> monsterRepository;

        public MonsterService()
        {
        monsterRepository = new MonsterRepository();
        }

        //Read
        public IEnumerable<Monster> GetAll()
        {
            var result =monsterRepository.FindAll();
            return result;
        }

        //Add 
        public bool Add(Monster monster)
        {
            bool result = false;
            var chk = monsterRepository.GetById(monster.Id);
            if (chk == null)
            {
                monsterRepository.Add(monster);
                result = true;
            }
            return result;
        }

        //Delete
        public bool Delete(int id)
        {
            bool result = false;
            var chk = monsterRepository.GetById(id);

            if (chk == null)
            {
                //to do something
            }
            else
            {
                monsterRepository.Remove(chk);
                result = true;
            }
            return result;
        }
        //Detail
        public Monster Query(int id)
        {
            var monster = monsterRepository.Find(x => x.Id == id).SingleOrDefault();
            return monster;
        }

        //Update
        public bool Update(Monster monster)
        {
            bool result = false;
            var chk = monsterRepository.GetById(monster.Id);
            if (chk == null)
            {
                //to do something
            }
            else
            {
                monsterRepository.Update(monster);
                result = true;
            }
            return result;
        }
    }
}