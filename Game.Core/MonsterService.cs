using Game.Common.Entities;
using Game.Common.Interfaces;
using Game.Dal;
using System.Collections.Generic;

namespace Game.Core
{
    public class MonsterService
    {
        IRepository<Monster> monsterRepository;

        public MonsterService()
        {
            monsterRepository = new MonsterRepository();
        }
        public IEnumerable<Monster> GetAll()
        {
            var result = monsterRepository.FindAll();
            return result;
        }
    }
}