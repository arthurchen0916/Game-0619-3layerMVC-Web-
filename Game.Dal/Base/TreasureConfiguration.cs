using Game.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Game.Dal.Base
{
    internal class TreasureConfiguration : EntityTypeConfiguration<Treasure>
    {
        public TreasureConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.MonsterID).IsRequired();
            this.Property(t => t.ItemID).IsRequired();

            // Table & Column Mappings
            this.ToTable("Treasure");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MonsterID).HasColumnName("MonsterID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
        }
    }
}