using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex17_dados_numa_listBox.Forms;

namespace ex17_dados_numa_listBox.classes
{
    internal class fechar
    {
        public static void fecharForm() 
        {
            foreach (Form frm in Application.OpenForms)
            {
                frm.Close();
            }
        }
        public static void voltarForm1(Form thisvar)
        {
            Form1 form1 = new Form1();
            form1.Show();
            thisvar.Hide();
        }
    }
}
