using Business.Abstract;
using Business.DependencyResolvers.Ninject;
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
        public Form1()
        {
            InitializeComponent();
            noteService = InstanceFactory.GetInstance<INoteService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = noteService.GetList();
        }
    }
}
