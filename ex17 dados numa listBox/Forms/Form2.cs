using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ex17_dados_numa_listBox.classes;

namespace ex17_dados_numa_listBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            fechar.fecharForm();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == dados.nome || textBox2.Text == dados.email && textBox3.Text == dados.pass)
            {
                MessageBox.Show("Bem vindo de volta!");
                fechar.abrirForm3(this);
            }
            else
            {
                MessageBox.Show("Password ou Utilizador errados!");
            }
        }

        private void lbCriar_Click(object sender, EventArgs e)
        {
            fechar.voltarForm1(this);
        }
    }
}
