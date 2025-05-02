namespace tube_mixing_software
{
    partial class Entrar
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
            entrarBtn = new Button();
            emailTxt = new TextBox();
            senhaTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // entrarBtn
            // 
            entrarBtn.BackColor = Color.FromArgb(60, 110, 113);
            entrarBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entrarBtn.ForeColor = Color.White;
            entrarBtn.Location = new Point(302, 358);
            entrarBtn.Margin = new Padding(2, 3, 2, 3);
            entrarBtn.Name = "entrarBtn";
            entrarBtn.Size = new Size(143, 39);
            entrarBtn.TabIndex = 3;
            entrarBtn.Text = "Entrar";
            entrarBtn.UseVisualStyleBackColor = false;
            entrarBtn.Click += entrarBtn_Click;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(168, 133);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(277, 23);
            emailTxt.TabIndex = 4;
            // 
            // senhaTxt
            // 
            senhaTxt.Location = new Point(168, 245);
            senhaTxt.Name = "senhaTxt";
            senhaTxt.Size = new Size(277, 23);
            senhaTxt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(60, 110, 113);
            label1.Location = new Point(168, 102);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(60, 110, 113);
            label2.Location = new Point(168, 212);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 7;
            label2.Text = "Senha";
            // 
            // Entrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 248);
            ClientSize = new Size(624, 601);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(senhaTxt);
            Controls.Add(emailTxt);
            Controls.Add(entrarBtn);
            Name = "Entrar";
            Text = "Entrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button entrarBtn;
        private TextBox emailTxt;
        private TextBox senhaTxt;
        private Label label1;
        private Label label2;
    }
}