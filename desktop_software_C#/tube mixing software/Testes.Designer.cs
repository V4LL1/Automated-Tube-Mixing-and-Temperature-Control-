namespace tube_mixing_software
{
    partial class Testes
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
            cmbPortas = new ComboBox();
            txtLog = new TextBox();
            btnConectar = new Button();
            lblTemperatura = new Label();
            btnRele1 = new Button();
            btnRele2 = new Button();
            btnRele3 = new Button();
            btnRele4 = new Button();
            txtTempo = new TextBox();
            SuspendLayout();
            // 
            // cmbPortas
            // 
            cmbPortas.FormattingEnabled = true;
            cmbPortas.Location = new Point(41, 46);
            cmbPortas.Name = "cmbPortas";
            cmbPortas.Size = new Size(121, 23);
            cmbPortas.TabIndex = 0;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(42, 99);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(729, 151);
            txtLog.TabIndex = 1;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(42, 415);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click_1;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(42, 72);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(74, 15);
            lblTemperatura.TabIndex = 3;
            lblTemperatura.Text = "Temperatura";
            // 
            // btnRele1
            // 
            btnRele1.Location = new Point(49, 285);
            btnRele1.Name = "btnRele1";
            btnRele1.Size = new Size(75, 23);
            btnRele1.TabIndex = 4;
            btnRele1.Text = "rele_1";
            btnRele1.UseVisualStyleBackColor = true;
            btnRele1.Click += btnRele1_Click_1;
            // 
            // btnRele2
            // 
            btnRele2.Location = new Point(130, 285);
            btnRele2.Name = "btnRele2";
            btnRele2.Size = new Size(75, 23);
            btnRele2.TabIndex = 5;
            btnRele2.Text = "rele_2";
            btnRele2.UseVisualStyleBackColor = true;
            btnRele2.Click += btnRele2_Click_1;
            // 
            // btnRele3
            // 
            btnRele3.Location = new Point(211, 285);
            btnRele3.Name = "btnRele3";
            btnRele3.Size = new Size(75, 23);
            btnRele3.TabIndex = 6;
            btnRele3.Text = "rele_3";
            btnRele3.UseVisualStyleBackColor = true;
            btnRele3.Click += btnRele3_Click_1;
            // 
            // btnRele4
            // 
            btnRele4.Location = new Point(292, 285);
            btnRele4.Name = "btnRele4";
            btnRele4.Size = new Size(75, 23);
            btnRele4.TabIndex = 7;
            btnRele4.Text = "rele_4";
            btnRele4.UseVisualStyleBackColor = true;
            btnRele4.Click += btnRele4_Click_1;
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(49, 256);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(100, 23);
            txtTempo.TabIndex = 8;
            // 
            // Testes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTempo);
            Controls.Add(btnRele4);
            Controls.Add(btnRele3);
            Controls.Add(btnRele2);
            Controls.Add(btnRele1);
            Controls.Add(lblTemperatura);
            Controls.Add(btnConectar);
            Controls.Add(txtLog);
            Controls.Add(cmbPortas);
            Name = "Testes";
            Text = "Testes";
            Load += Testes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPortas;
        private TextBox txtLog;
        private Button btnConectar;
        private Label lblTemperatura;
        private Button btnRele1;
        private Button btnRele2;
        private Button btnRele3;
        private Button btnRele4;
        private TextBox txtTempo;
    }
}