namespace tube_mixing_software
{
    partial class Inicio
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
            EntrarBtn = new Button();
            RegistrarBtn = new Button();
            SairBtn = new Button();
            SuspendLayout();
            // 
            // EntrarBtn
            // 
            EntrarBtn.BackColor = Color.FromArgb(60, 110, 113);
            EntrarBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EntrarBtn.ForeColor = Color.White;
            EntrarBtn.Location = new Point(227, 139);
            EntrarBtn.Margin = new Padding(2, 3, 2, 3);
            EntrarBtn.Name = "EntrarBtn";
            EntrarBtn.Size = new Size(170, 62);
            EntrarBtn.TabIndex = 4;
            EntrarBtn.Text = "Entrar";
            EntrarBtn.UseVisualStyleBackColor = false;
            EntrarBtn.Click += EntrarBtn_Click;
            // 
            // RegistrarBtn
            // 
            RegistrarBtn.BackColor = Color.FromArgb(60, 110, 113);
            RegistrarBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistrarBtn.ForeColor = Color.White;
            RegistrarBtn.Location = new Point(227, 256);
            RegistrarBtn.Margin = new Padding(2, 3, 2, 3);
            RegistrarBtn.Name = "RegistrarBtn";
            RegistrarBtn.Size = new Size(170, 62);
            RegistrarBtn.TabIndex = 5;
            RegistrarBtn.Text = "Registrar";
            RegistrarBtn.UseVisualStyleBackColor = false;
            RegistrarBtn.Click += RegistrarBtn_Click;
            // 
            // SairBtn
            // 
            SairBtn.BackColor = Color.FromArgb(60, 110, 113);
            SairBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SairBtn.ForeColor = Color.White;
            SairBtn.Location = new Point(227, 380);
            SairBtn.Margin = new Padding(2, 3, 2, 3);
            SairBtn.Name = "SairBtn";
            SairBtn.Size = new Size(170, 62);
            SairBtn.TabIndex = 6;
            SairBtn.Text = "Sair";
            SairBtn.UseVisualStyleBackColor = false;
            SairBtn.Click += SairBtn_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 248);
            ClientSize = new Size(624, 601);
            Controls.Add(SairBtn);
            Controls.Add(RegistrarBtn);
            Controls.Add(EntrarBtn);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button EntrarBtn;
        private Button RegistrarBtn;
        private Button SairBtn;
    }
}