using System;
using ex17_dados_numa_listBox.classes;
using ex17_dados_numa_listBox.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ex17_dados_numa_listBox
{
    public partial class Form1 : Form
    {
        private Form4 frm4;
        public Form1()
        {
            InitializeComponent();
            frm4 = new Form4(this);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            fechar.fecharForm();
        }

        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm4.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            string Email = txtEmail.Text;
            string Password = txtPass.Text;

            if (txtNome.Text == "" || txtEmail.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Não inseriu dados suficientes para cria a conta!");
            }
            else
            {
                MessageBox.Show("Utilizador " + Nome + " criado com sucesso");
                ClearDados();
            }
        }
        public void ClearDados()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void lbSessao_Click(object sender, EventArgs e)
        {
            fechar.voltarForm2(this);
        }

        private void pcPerfil_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtEmail.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Não tem conta criada!");

            }
            else
            {
                fechar.abrirForm3(this);
            }
        }
    }
}
