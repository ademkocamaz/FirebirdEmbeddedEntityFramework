using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class NoteMap:EntityTypeConfiguration<Note>
    {
        public NoteMap()
        {
            ToTable("NOTES");
            HasKey(x => x.Id);
            Property(x => x.Title).HasColumnName("TITLE");
            Property(x => x.Detail).HasColumnName("DETAIL");
        }

    }
}
