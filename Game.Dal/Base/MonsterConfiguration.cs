using Game.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Game.Dal.Base
{
    internal class MonsterConfiguration : EntityTypeConfiguration<Monster>
    {
        public MonsterConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.HP);
            this.Property(t => t.ATK);
            this.Property(t => t.Exp);

            // Table & Column Mappings
            this.ToTable("Monster");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.HP).HasColumnName("HP");
            this.Property(t => t.ATK).HasColumnName("ATK");
            this.Property(t => t.Exp).HasColumnName("EXP");
        }
    }
}