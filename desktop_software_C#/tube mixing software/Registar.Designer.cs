namespace tube_mixing_software
{
    partial class Registar
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
            label2 = new Label();
            label1 = new Label();
            senhaTxt = new TextBox();
            emailTxt = new TextBox();
            registarBtn = new Button();
            labeltxt = new Label();
            senhaAdminTxt = new TextBox();
            label4 = new Label();
            nomeTxt = new TextBox();
            cargoTxt = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(60, 110, 113);
            label2.Location = new Point(137, 224);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 12;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(60, 110, 113);
            label1.Location = new Point(137, 142);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 11;
            label1.Text = "Email";
            // 
            // senhaTxt
            // 
            senhaTxt.Location = new Point(137, 257);
            senhaTxt.Name = "senhaTxt";
            senhaTxt.Size = new Size(277, 25);
            senhaTxt.TabIndex = 10;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(137, 173);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(277, 25);
            emailTxt.TabIndex = 9;
            // 
            // registarBtn
            // 
            registarBtn.BackColor = Color.FromArgb(60, 110, 113);
            registarBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registarBtn.ForeColor = Color.White;
            registarBtn.Location = new Point(271, 520);
            registarBtn.Margin = new Padding(2, 3, 2, 3);
            registarBtn.Name = "registarBtn";
            registarBtn.Size = new Size(143, 39);
            registarBtn.TabIndex = 8;
            registarBtn.Text = "Registrar";
            registarBtn.UseVisualStyleBackColor = false;
            registarBtn.Click += registarBtn_Click;
            // 
            // labeltxt
            // 
            labeltxt.AutoSize = true;
            labeltxt.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltxt.ForeColor = Color.FromArgb(60, 110, 113);
            labeltxt.Location = new Point(137, 407);
            labeltxt.Name = "labeltxt";
            labeltxt.Size = new Size(192, 18);
            labeltxt.TabIndex = 14;
            labeltxt.Text = "Senha de administrador";
            // 
            // senhaAdminTxt
            // 
            senhaAdminTxt.Location = new Point(137, 440);
            senhaAdminTxt.Name = "senhaAdminTxt";
            senhaAdminTxt.Size = new Size(277, 25);
            senhaAdminTxt.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(60, 110, 113);
            label4.Location = new Point(137, 66);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 16;
            label4.Text = "Nome";
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(137, 99);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(277, 25);
            nomeTxt.TabIndex = 15;
            // 
            // cargoTxt
            // 
            cargoTxt.FormattingEnabled = true;
            cargoTxt.Location = new Point(137, 346);
            cargoTxt.Name = "cargoTxt";
            cargoTxt.Size = new Size(277, 26);
            cargoTxt.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(60, 110, 113);
            label5.Location = new Point(137, 316);
            label5.Name = "label5";
            label5.Size = new Size(53, 18);
            label5.TabIndex = 18;
            label5.Text = "Cargo";
            // 
            // Registar
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 248);
            ClientSize = new Size(624, 601);
            Controls.Add(label5);
            Controls.Add(cargoTxt);
            Controls.Add(label4);
            Controls.Add(nomeTxt);
            Controls.Add(labeltxt);
            Controls.Add(senhaAdminTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(senhaTxt);
            Controls.Add(emailTxt);
            Controls.Add(registarBtn);
            Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(60, 110, 113);
            Margin = new Padding(4);
            Name = "Registar";
            Text = "Registar";
            Load += Registar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox senhaTxt;
        private TextBox emailTxt;
        private Button registarBtn;
        private Label labeltxt;
        private TextBox senhaAdminTxt;
        private Label label4;
        private TextBox nomeTxt;
        private ComboBox cargoTxt;
        private Label label5;
    }
}