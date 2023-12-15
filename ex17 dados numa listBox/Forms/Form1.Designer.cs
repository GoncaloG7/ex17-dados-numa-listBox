namespace ex17_dados_numa_listBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbShow = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbSessao = new Label();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            btnSeguinte = new Button();
            btnGuardar = new Button();
            btnFechar = new Button();
            pcPerfil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcPerfil).BeginInit();
            SuspendLayout();
            // 
            // cbShow
            // 
            cbShow.AutoSize = true;
            cbShow.Location = new Point(156, 177);
            cbShow.Name = "cbShow";
            cbShow.Size = new Size(15, 14);
            cbShow.TabIndex = 21;
            cbShow.UseVisualStyleBackColor = true;
            cbShow.CheckedChanged += cbShow_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 155);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 17;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 102);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 16;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 48);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 15;
            label2.Text = "Nome";
            // 
            // lbSessao
            // 
            lbSessao.AutoSize = true;
            lbSessao.Location = new Point(108, 220);
            lbSessao.Name = "lbSessao";
            lbSessao.Size = new Size(106, 15);
            lbSessao.TabIndex = 14;
            lbSessao.Text = "Ja tem uma conta?";
            lbSessao.Click += lbSessao_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(75, 173);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 13;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(75, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(75, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 11;
            // 
            // btnSeguinte
            // 
            btnSeguinte.Location = new Point(238, 251);
            btnSeguinte.Name = "btnSeguinte";
            btnSeguinte.Size = new Size(75, 23);
            btnSeguinte.TabIndex = 23;
            btnSeguinte.Text = "Lista";
            btnSeguinte.UseVisualStyleBackColor = true;
            btnSeguinte.Click += btnSeguinte_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(238, 280);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(278, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(35, 24);
            btnFechar.TabIndex = 24;
            btnFechar.Text = "❌";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // pcPerfil
            // 
            pcPerfil.Image = Properties.Resources.image_removebg_preview__13_;
            pcPerfil.Location = new Point(1, 0);
            pcPerfil.Name = "pcPerfil";
            pcPerfil.Size = new Size(43, 48);
            pcPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pcPerfil.TabIndex = 25;
            pcPerfil.TabStop = false;
            pcPerfil.Click += pcPerfil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 305);
            Controls.Add(pcPerfil);
            Controls.Add(btnFechar);
            Controls.Add(btnSeguinte);
            Controls.Add(btnGuardar);
            Controls.Add(cbShow);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbSessao);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Criar Conta";
            ((System.ComponentModel.ISupportInitialize)pcPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbShow;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbSessao;
        private TextBox txtPass;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Button btnSeguinte;
        private Button btnGuardar;
        private Button btnFechar;
        private PictureBox pcPerfil;
    }
}
