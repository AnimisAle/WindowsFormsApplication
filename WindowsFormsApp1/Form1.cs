using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to the jungle!!!! :)  PELO CONSTRUTOR");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Olá Lucas send salve man  " + cboEstados.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtResultado.Text; 
            form.Show(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to the jungle!!!! :) ");
            List<string> estados = new List<string>();
            estados.Add("SP");
            estados.Add("BA");
            estados.Add("RJ");
            estados.Add("GO");
        }
    }
}
