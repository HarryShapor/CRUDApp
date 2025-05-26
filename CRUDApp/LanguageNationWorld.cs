using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CRUDApp
{
    public partial class LanguageNationWorld : DbContext
    {
        public LanguageNationWorld(string connection)
            : base(connection)
        {
        }
        public virtual DbSet<Страны> Страны { get; set; }
        public virtual DbSet<ЭтническийСостав> ЭтническийСостав { get; set; }
        public virtual DbSet<Языки> Языки { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Страны>()
                .Property(e => e.Название)
                .IsUnicode(false);

            modelBuilder.Entity<Страны>()
                .Property(e => e.Материк)
                .IsUnicode(false);

            modelBuilder.Entity<Страны>()
                .Property(e => e.Столица)
                .IsUnicode(false);

            modelBuilder.Entity<Страны>()
                .HasMany(e => e.ЭтническийСостав)
                .WithRequired(e => e.Страны)
                .HasForeignKey(e => e.Страна)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Языки>()
                .Property(e => e.Название)
                .IsUnicode(false);

            modelBuilder.Entity<Языки>()
                .Property(e => e.Языковая_группа)
                .IsUnicode(false);

            modelBuilder.Entity<Языки>()
                .Property(e => e.Вид_знаковой_системы)
                .IsUnicode(false);

            modelBuilder.Entity<Языки>()
                .HasMany(e => e.ЭтническийСостав)
                .WithRequired(e => e.Языки)
                .HasForeignKey(e => e.Язык)
                .WillCascadeOnDelete(false);
        }
    }
}
