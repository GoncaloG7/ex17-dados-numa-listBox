namespace ex17_dados_numa_listBox.Forms
{
    partial class Form3
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
            pictureBox1 = new PictureBox();
            lbNome = new Label();
            lbEmail = new Label();
            button1 = new Button();
            btnVoltar = new Button();
            label2 = new Label();
            label3 = new Label();
            lbPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_removebg_preview__13_;
            pictureBox1.Location = new Point(69, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(180, 174);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            lbNome.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(159, 230);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            lbEmail.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            button1.Location = new Point(364, 1);
            button1.Name = "button1";
            button1.Size = new Size(33, 23);
            button1.TabIndex = 3;
            button1.Text = "❌";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(2, 1);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(42, 23);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "⬅";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 230);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 256);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(159, 256);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(77, 15);
            lbPass.TabIndex = 9;
            lbPass.Text = "◾◾◾◾◾◾◾";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 384);
            Controls.Add(lbPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnVoltar);
            Controls.Add(button1);
            Controls.Add(lbEmail);
            Controls.Add(lbNome);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Perfil";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbNome;
        private Label lbEmail;
        private Button button1;
        private Button btnVoltar;
        private Label label2;
        private Label label3;
        private Label lbPass;
    }
}