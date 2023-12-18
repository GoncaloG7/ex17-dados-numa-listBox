using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ex17_dados_numa_listBox.classes
{
    public class dados
    {
        public string nome;
        public string email;
        public string pass;

        public dados(string Nome, string Email, string Password)
        {
            nome = Nome;
            email = Email;
            pass = Password;
        }

        public static List<dados> listaUtilizadores = new List<dados>();
       
        public static void Registar(string nome, string email, string password)
        {
            dados novoUtilizador = new dados(nome, email, password);
            listaUtilizadores.Add(novoUtilizador);
        }
    }
}
