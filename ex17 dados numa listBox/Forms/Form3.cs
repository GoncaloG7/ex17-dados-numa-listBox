﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ex17_dados_numa_listBox.classes;

namespace ex17_dados_numa_listBox.Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            lbNome.Text = dados.nome;
            lbEmail.Text = dados.email;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }

        private void Form3_Load(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            fechar.fecharForm();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fechar.voltarForm1(this);
        }

        private void btnMudar_Click(object sender, EventArgs e)
        {
            fechar.voltarForm1(this);
        }
    }
}
