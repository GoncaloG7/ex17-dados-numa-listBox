using System;
using System.Diagnostics.Eventing.Reader;
using ex17_dados_numa_listBox.classes;
using ex17_dados_numa_listBox.Forms;
using Microsoft.Win32;
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
        public void ClearDados()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
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

            /*->1<-
                 if (string.IsNullOrEmpty(Nome))
                    MessageBox.Show("Por favor escreva o Nome");
            else if (string.IsNullOrEmpty(Email))
                    MessageBox.Show("Por favor escreva o Email");
            else if (string.IsNullOrEmpty(Password))
                    MessageBox.Show("Por favor escreva a Password");
            else
                  //Metodo Registar com os parametros recebidos (nome, email e password)
                    MessageBox.Show("Utilizador " + Nome + " criado com sucesso");
                    ClearDados();*/

            /*->2<-
            string P_Nome = "";
            string P_Email = "";
            string P_Password = "";
                 if (Nome == "")
                    P_Nome = "Nome";
                 if (Email == "")
                    P_Email = "Email";
                 if (Password == "")
                    P_Password = "Password";
                 ---
                 if (Nome + Email + Password == "")
                    MessageBox.Show("Utilizador " + Nome + " criado com sucesso");
                 else
                    MessageBox.Show("Não Preecheu" + P_Nome + P_Email + P_Password);*/

            /*->3<-*/
            if (Nome == "" & Email == "" & Password == "")
                MessageBox.Show("Falta inserir todos os dados para cria uma conta!");
            else if (Nome == "" & Email == "")
                MessageBox.Show("Falta inserir o Nome e o Email para cria a conta!");
            else if (Nome == "" & Password == "")
                MessageBox.Show("Falta inserir o Nome e a Password para cria a conta!");
            else if (Email == "" & Password == "")
                MessageBox.Show("Falta inserir o Email e a Password para cria a conta!");
            else if (Nome == "")
                MessageBox.Show("Falta inserir o Email para cria a conta!");
            else if (Email == "")
                MessageBox.Show("Falta inserir o Email para cria a conta!");
            else if (Password == "")
                MessageBox.Show("Falta inserir a Password para cria a conta!");
            else
                //Metodo Registar com os parametros recebidos (nome, email e password)
                dados.Registar(Nome, Email, Password);
                MessageBox.Show("Utilizador " + Nome + " criado com sucesso");
                ClearDados();
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
    }
}
