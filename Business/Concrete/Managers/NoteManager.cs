using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Managers
{
    public class NoteManager : INoteService
    {
        private INoteDal noteDal;
        public NoteManager(INoteDal noteDal)
        {
            this.noteDal = noteDal;
        }
        public Note Add(Note entity)
        {
            return noteDal.Add(entity);
        }

        public void Delete(Note entity)
        {
            noteDal.Delete(entity);
        }

        public Note Get(Expression<Func<Note, bool>> filter)
        {
            return noteDal.Get(filter);
        }

        public List<Note> GetList(Expression<Func<Note, bool>> filter = null)
        {
            return noteDal.GetList(filter);
        }

        public Note Update(Note entity)
        {
            return noteDal.Update(entity);
        }
    }
}
