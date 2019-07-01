using Game.Common.Entities;
using System.Data.Entity;

namespace Game.Dal.Base
{
    public partial class GameContext : DbContext
    {
        public GameContext()
            : base("name=GameContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ItemConfiguration());
            modelBuilder.Configurations.Add(new MonsterConfiguration());
            modelBuilder.Configurations.Add(new MemberConfiguration());
            modelBuilder.Configurations.Add(new TreasureConfiguration());
        }

        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Monster> Monster { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Treasure> Treasure { get; set; }
    }
}