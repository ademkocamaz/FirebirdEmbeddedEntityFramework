using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NotesContext : DbContext
    {
        public NotesContext() : base(new FbConnection(NotesDatabase.connectionString), true)
        {
            Database.SetInitializer(new NotesDatabaseInitializer());
        }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Properties().Configure(x => x.HasColumnName(x.ClrPropertyInfo.Name.ToUpper()));

            //var notesConf = modelBuilder.Entity<Note>();
            //notesConf.ToTable("NOTES");

            //modelBuilder.Configurations.Add(new NoteMap());
        }
    }
}
