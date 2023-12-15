namespace ex17_dados_numa_listBox
{
    partial class Form2
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
            btnFechar = new Button();
            btnEntrar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbCriar = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            cbShow = new CheckBox();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(278, 2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(35, 24);
            btnFechar.TabIndex = 25;
            btnFechar.Text = "❌";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(238, 278);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 24;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 102);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 23;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 49);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 22;
            label3.Text = "Nome ou Gmail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 49);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 21;
            // 
            // lbCriar
            // 
            lbCriar.AutoSize = true;
            lbCriar.Location = new Point(108, 220);
            lbCriar.Name = "lbCriar";
            lbCriar.Size = new Size(126, 15);
            lbCriar.TabIndex = 20;
            lbCriar.Text = "Não tem conta criada?";
            lbCriar.Click += lbCriar_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(68, 120);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 18;
            // 
            // cbShow
            // 
            cbShow.AutoSize = true;
            cbShow.Location = new Point(153, 124);
            cbShow.Name = "cbShow";
            cbShow.Size = new Size(15, 14);
            cbShow.TabIndex = 26;
            cbShow.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 304);
            Controls.Add(cbShow);
            Controls.Add(btnFechar);
            Controls.Add(btnEntrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbCriar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "Form2";
            Text = "Iniciar sessão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private Button btnEntrar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbCriar;
        private TextBox textBox3;
        private TextBox textBox2;
        private CheckBox cbShow;
    }
}