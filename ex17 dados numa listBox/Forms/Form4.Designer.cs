namespace ex17_dados_numa_listBox.Forms
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            contas = new ListBox();
            btnFechar = new Button();
            btnVoltar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // contas
            // 
            contas.FormattingEnabled = true;
            contas.ItemHeight = 15;
            contas.Location = new Point(117, 77);
            contas.Name = "contas";
            contas.Size = new Size(159, 229);
            contas.TabIndex = 0;
            contas.SelectedIndexChanged += contas_SelectedIndexChanged;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(361, 1);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(35, 24);
            btnFechar.TabIndex = 26;
            btnFechar.Text = "❌";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(2, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(42, 23);
            btnVoltar.TabIndex = 27;
            btnVoltar.Text = "⬅";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(160, 312);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 28;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 384);
            Controls.Add(button1);
            Controls.Add(btnVoltar);
            Controls.Add(btnFechar);
            Controls.Add(contas);
            Name = "Form4";
            Text = "Lista de Contas";
            ResumeLayout(false);
        }

        #endregion

        private ListBox contas;
        private Button btnFechar;
        private Button btnVoltar;
        private Button button1;
    }
}