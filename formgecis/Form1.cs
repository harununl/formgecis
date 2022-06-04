using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formgecis
{
    public partial class FrmPanel : Form
    {
        
        public FrmPanel()
        {
            InitializeComponent();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            FrmPersonnel frm = new FrmPersonnel(this);
            //this.Hide();
            frm.ShowDialog();
            //this.Visible = true;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void FrmPanel_Load(object sender, EventArgs e)
        {

           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // int rowindex;
            //rowindex = e.RowIndex;

            //DataRow row = (dataGridView1.Rows[rowindex].DataBoundItem as DataRowView).Row;

            FrmPersonnel frm = new FrmPersonnel(this);

            frm.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtCity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtSalary.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();


            frm.btnSave.Enabled = false;

            frm.ShowDialog();
          







        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            
            
            dataGridView1.Rows.RemoveAt(rowIndex);
            //dataGridView1.Rows.RemoveAt(0);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
