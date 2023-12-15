using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ex17_dados_numa_listBox.classes;

namespace ex17_dados_numa_listBox.Forms
{
    public partial class Form4 : Form
    {
        private Form1 frm1;
        public Form4(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            fechar.fecharForm();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.Show();
        }

        private void contas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach( )
        }
    }
}
