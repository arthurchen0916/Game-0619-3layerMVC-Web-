using Game.Common.Entities;
using Game.Common.Interfaces;
using Game.Dal.Base;
using System.Collections.Generic;

namespace Game.Dal
{
    public class TreasureRepository : BaseRepository<Treasure>, ITreasureRepository
    {
        public TreasureRepository()
        {
        }

        public IEnumerable<MonsterItem> QueryNameBySql(string sql, params object[] parameters)
        {
            return _dbContext.Database.SqlQuery<MonsterItem>(sql, parameters);
        }
    }
}