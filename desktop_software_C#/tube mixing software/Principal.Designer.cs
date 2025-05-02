namespace tube_mixing_software
{
    partial class Principal
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
            funcionarioLbl = new Label();
            sairBtn = new Button();
            historicoBtn = new Button();
            iniciarBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            tempLbl = new Label();
            umidadeLbl = new Label();
            SuspendLayout();
            // 
            // funcionarioLbl
            // 
            funcionarioLbl.AutoSize = true;
            funcionarioLbl.Location = new Point(17, 11);
            funcionarioLbl.Margin = new Padding(4, 0, 4, 0);
            funcionarioLbl.Name = "funcionarioLbl";
            funcionarioLbl.Size = new Size(0, 18);
            funcionarioLbl.TabIndex = 0;
            // 
            // sairBtn
            // 
            sairBtn.BackColor = Color.FromArgb(60, 110, 113);
            sairBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sairBtn.ForeColor = Color.White;
            sairBtn.Location = new Point(265, 435);
            sairBtn.Margin = new Padding(2, 3, 2, 3);
            sairBtn.Name = "sairBtn";
            sairBtn.Size = new Size(170, 62);
            sairBtn.TabIndex = 9;
            sairBtn.Text = "Sair";
            sairBtn.UseVisualStyleBackColor = false;
            sairBtn.Click += sairBtn_Click;
            // 
            // historicoBtn
            // 
            historicoBtn.BackColor = Color.FromArgb(60, 110, 113);
            historicoBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historicoBtn.ForeColor = Color.White;
            historicoBtn.Location = new Point(265, 311);
            historicoBtn.Margin = new Padding(2, 3, 2, 3);
            historicoBtn.Name = "historicoBtn";
            historicoBtn.Size = new Size(170, 62);
            historicoBtn.TabIndex = 8;
            historicoBtn.Text = "Historico";
            historicoBtn.UseVisualStyleBackColor = false;
            historicoBtn.Click += historicoBtn_Click;
            // 
            // iniciarBtn
            // 
            iniciarBtn.BackColor = Color.FromArgb(60, 110, 113);
            iniciarBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iniciarBtn.ForeColor = Color.White;
            iniciarBtn.Location = new Point(265, 194);
            iniciarBtn.Margin = new Padding(2, 3, 2, 3);
            iniciarBtn.Name = "iniciarBtn";
            iniciarBtn.Size = new Size(170, 62);
            iniciarBtn.TabIndex = 7;
            iniciarBtn.Text = "Iniciar";
            iniciarBtn.UseVisualStyleBackColor = false;
            iniciarBtn.Click += iniciarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(634, 180);
            label1.Name = "label1";
            label1.Size = new Size(159, 18);
            label1.TabIndex = 10;
            label1.Text = "Temperatura atual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(634, 390);
            label2.Name = "label2";
            label2.Size = new Size(127, 18);
            label2.TabIndex = 11;
            label2.Text = "Umidade atual:";
            // 
            // tempLbl
            // 
            tempLbl.AutoSize = true;
            tempLbl.Font = new Font("Georgia", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tempLbl.Location = new Point(653, 218);
            tempLbl.Name = "tempLbl";
            tempLbl.Size = new Size(108, 72);
            tempLbl.TabIndex = 12;
            tempLbl.Text = "25";
            // 
            // umidadeLbl
            // 
            umidadeLbl.AutoSize = true;
            umidadeLbl.Font = new Font("Georgia", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            umidadeLbl.Location = new Point(653, 435);
            umidadeLbl.Name = "umidadeLbl";
            umidadeLbl.Size = new Size(108, 72);
            umidadeLbl.TabIndex = 13;
            umidadeLbl.Text = "25";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 248);
            ClientSize = new Size(1009, 729);
            Controls.Add(umidadeLbl);
            Controls.Add(tempLbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sairBtn);
            Controls.Add(historicoBtn);
            Controls.Add(iniciarBtn);
            Controls.Add(funcionarioLbl);
            Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(60, 110, 113);
            Margin = new Padding(4);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label funcionarioLbl;
        private Button sairBtn;
        private Button historicoBtn;
        private Button iniciarBtn;
        private Label label1;
        private Label label2;
        private Label tempLbl;
        private Label umidadeLbl;
    }
}