using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{

    public class Note:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
       
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }



    }
}
