using Game.Common.Entities;
using System.Collections.Generic;


namespace Game.Common.Interfaces
{
    public interface ITreasureRepository : IRepository<Treasure>
    {
        IEnumerable<MonsterItem> QueryNameBySql(string sql, params object[] parameters);
    }
}