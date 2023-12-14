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
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(180, 205);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 384);
            Controls.Add(lbEmail);
            Controls.Add(lbNome);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbNome;
        private Label lbEmail;
    }
}