using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        private INoteService noteService;
        private ICategoryService categoryService;

        public Form1()
        {
            InitializeComponent();
            noteService = InstanceFactory.GetInstance<INoteService>();
            categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = noteService.GetList();
            dataGridView2.DataSource = categoryService.GetList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var entity = noteService.Get(x => x.Id.Equals(4));
            //MessageBox.Show(entity.Category.Name);

            using (var context = new NotesDatabaseContext())
            {
                var note = context.Notes.Where(x => x.Id == 4).FirstOrDefault();
                MessageBox.Show(context.Categories.Where(x=>x.Id==note.CategoryId).FirstOrDefault().Name);
            }
        }
    }
}
