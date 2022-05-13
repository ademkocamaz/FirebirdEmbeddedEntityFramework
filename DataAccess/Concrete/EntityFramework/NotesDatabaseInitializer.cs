﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NotesDatabaseInitializer:DropCreateDatabaseIfModelChanges<NotesContext>
    {
        protected override void Seed(NotesContext context)
        {
            List<Note> notes = new List<Note>()
            {
                new Note(){Title="Test Title",Detail="Test Detail",Description="Test Description",Date=DateTime.Now},
                new Note(){Title="Test Title",Detail="Test Detail",Description="Test Description",Date=DateTime.Now},
                new Note(){Title="Test Title",Detail="Test Detail",Description="Test Description",Date=DateTime.Now},
                new Note(){Title="Test Title",Detail="Test Detail",Description="Test Description",Date=DateTime.Now},
                new Note(){Title="Test Title",Detail="Test Detail",Description="Test Description",Date=DateTime.Now},
                new Note(){Title="Test Title",Detail="Test Detail",Description="Test Description",Date=DateTime.Now},
                new Note(){Title="Test Title",Detail="Test Detail",Description="Test Description",Date=DateTime.Now}
            };
            foreach (var note in notes)
            {
                context.Notes.Add(note);
            }
            context.SaveChanges();
            
            base.Seed(context);
        }

    }
}
