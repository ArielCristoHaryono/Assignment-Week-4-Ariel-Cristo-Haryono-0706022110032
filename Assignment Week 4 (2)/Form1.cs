using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Week_4__2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable dataInput = new DataTable();

        private void txtBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxTelp_TextChanged(object sender, EventArgs e)
        {
        }
        private static bool validate(char c)
        {
            int asci = Convert.ToInt32(c);
            if (asci >= 48 && asci <= 57 || asci == 13 || asci == 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtBoxTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validate(e.KeyChar);
        }

        private void btnLihatData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataInput.Columns.Add("Nama");
            dataInput.Columns.Add("Alamat");
            dataInput.Columns.Add("Telp");
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //dataInput.Rows.Add(txtBoxNama.Text, txtBoxAlamat.Text, txtBoxTelp.Text);
        }  
    }
}

