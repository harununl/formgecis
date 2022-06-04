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
    public partial class FrmPersonnel : Form
    {
        FrmPanel frm1dgw;
        public FrmPersonnel(FrmPanel frm1)
        {
            InitializeComponent();
            this.frm1dgw= frm1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPanel frm = new FrmPanel();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


       

        private void btnSave_Click(object sender, EventArgs e)
        {
/*
            int perID;
            string perName;
            string perSurname;
            string perCity;
            double perSalary;

             
            int.TryParse(txtID.Text,out perID);
            perName = txtName.Text;
            perSurname = txtSurname.Text;
            perCity = txtCity.Text;
            double.TryParse(txtSalary.Text,out perSalary);

            */

            FrmPanel frm = new FrmPanel();


           frm1dgw.dataGridView1.Rows.Add(txtID.Text,txtName.Text,txtSurname.Text,txtCity.Text,rdbtnMarried.Checked,txtSalary.Text);

            frm1dgw.Show();
           
      

            
            







        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmPanel frm = new FrmPanel();
            this.Hide();
            frm1dgw.Show();
           // frm.ShowDialog();
            

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            FrmPanel frm = new FrmPanel();
            int rowIndex = frm1dgw.dataGridView1.CurrentCell.RowIndex;

            DataGridViewRow newData = frm1dgw.dataGridView1.Rows[rowIndex];

            newData.Cells[0].Value = txtID.Text;
            newData.Cells[1].Value = txtName.Text;
            newData.Cells[2].Value = txtSurname.Text;
            newData.Cells[3].Value = txtCity.Text;
            newData.Cells[4].Value = rdbtnMarried.Checked;
            newData.Cells[5].Value = txtSalary.Text;

            frm1dgw.Show();
          
            
        }
    }
}
