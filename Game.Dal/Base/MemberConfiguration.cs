using Game.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Game.Dal.Base
{
    internal class MemberConfiguration : EntityTypeConfiguration<Member>
    {
        public MemberConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Account).IsRequired();
            this.Property(t => t.Password).IsRequired();

            // Table & Column Mappings
            this.ToTable("Member");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Account).HasColumnName("Account");
            this.Property(t => t.Password).HasColumnName("Password");
        }
    }
}