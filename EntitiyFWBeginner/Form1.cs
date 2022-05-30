using EntitiyFWBeginner.Context;
using EntitiyFWBeginner.Model.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyFWBeginner
{
    public partial class Form1 : Form
    {

        AppDbContext db = new AppDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDatasFromDB();
        }

        public void GetDatasFromDB()
        {
            dataGridView1.DataSource = db.Categories
                .Where(p=>p.status!=Model.Abstract.Status.Passive)
                .Select(x => new {
                x.Id,
                x.Name,
                x.Description,
                x.CreateDate,
                x.status
            }).ToList();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // Using does not wait for garbage collector istead
            // Trashes the context inside the scopes after executing it
            using (db)
            {
                Category category = new Category();
                category.Name = textName.Text;
                category.Description = textDescr.Text;

                // New Entity goes to database
                db.Categories.Add(category);
                db.SaveChanges();

                GetDatasFromDB();
            }
        }

        private void dataGridView1_CellContentClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                label3.Text = row.Cells[0].Value.ToString();
                textName.Text = row.Cells[1].Value.ToString();
                textDescr.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var category = db.Categories.FirstOrDefault(p => p.Id==int.Parse(label3.Text));

            category.Name = textName.Text;
            category.Description = textDescr.Text;
            category.UpdateDate = DateTime.Now;
            category.status = Model.Abstract.Status.Modify;
            db.Categories.Update(category);
            db.SaveChanges();

            GetDatasFromDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var category = db.Categories.FirstOrDefault(p => p.Id == int.Parse(label3.Text));

            category.DeleteDate = DateTime.Now;
            category.status = Model.Abstract.Status.Passive;
            db.Categories.Update(category);
            db.SaveChanges();

            GetDatasFromDB();
        }
    }
}
