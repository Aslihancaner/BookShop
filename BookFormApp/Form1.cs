using BookShop.Bussines.Concrete;
using BookShop.DataAcces.Concrete.AdoNet;
using BookShop.DataAcces.Concrete.EntityFramework;
using BookShop.DataAcces.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bookManager = new BookManager(new AdoBookDal());
            dataGridView1.DataSource = bookManager.GetAll();
        }
    }
}
