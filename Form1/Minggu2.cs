using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minggu2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form1
{
    public partial class Minggu2 : Form
    {
        public Minggu2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Minggu2_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = listPengguna;
            comboBox1.DisplayMember = "username";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        BindingList<pengguna> listPengguna = new BindingList<pengguna>();
        private void registerBtn_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String alamat = txtAlamat.Text;
            String jenisKelamin = "";

            if(M.Checked)
            {
                jenisKelamin = M.Text;
            } else if (F.Checked)
            {
                jenisKelamin = F.Text;
            }

            pengguna p = new pengguna(txtUsername.Text, txtPassword.Text, jenisKelamin, txtAlamat.Text);
            listPengguna.Add(p);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listPengguna.Count>0)
            {
                pengguna p = (pengguna)comboBox1.SelectedItem;
                listBox1.Items.Clear();
                listBox1.Items.Add("Username: " + p.Username);
                listBox1.Items.Add("Password: " + p.Password);
                listBox1.Items.Add("Jenis Kelamin: " + p.JK);
                listBox1.Items.Add("Alamat: " + p.Alamat);
            }
        }
    }
}
