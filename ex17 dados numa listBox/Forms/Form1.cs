using System;
using ex17_dados_numa_listBox.classes;

namespace ex17_dados_numa_listBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSeguinte.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            fechar.fecharForm();
        }

        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            fechar.abrirForm3(this);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtEmail.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Não inseriu dados suficientes para cria a conta!");

            }
            else
            {
                dados.nome = txtNome.Text;
                dados.email = txtEmail.Text;
                dados.pass = txtPass.Text;
                MessageBox.Show("Criado com sucesso" + "\nNome: " + dados.nome + "\nGmail: " + dados.email + "\nPassword: " + dados.pass);
                txtNome.Text = "";
                txtEmail.Text = "";
                txtPass.Text = "";
                btnSeguinte.Show();
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void lbSessao_Click(object sender, EventArgs e)
        {
            fechar.voltarForm2(this);
        }
    }
}
