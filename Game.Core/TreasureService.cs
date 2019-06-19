using Game.Common.Entities;
using Game.Common.Interfaces;
using Game.Dal;
using System.Collections.Generic;

namespace Game.Core
{
    public class TreasureService
    {
        IRepository<Treasure> TreasureRepository;

        public TreasureService()
        {
            TreasureRepository = new TreasureRepository();
        }
        public IEnumerable<Treasure> GetAll()
        {
            var result = TreasureRepository.FindAll();
            return result;
        }
    }
}