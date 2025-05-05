namespace tube_mixing_software
{
    partial class Iniciar
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
            components = new System.ComponentModel.Container();
            iniciarBtn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
            txtTemp = new TextBox();
            label1 = new Label();
            tempoTxt = new TextBox();
            tempLbl = new Label();
            SuspendLayout();
            // 
            // iniciarBtn
            // 
            iniciarBtn.BackColor = Color.FromArgb(60, 110, 113);
            iniciarBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iniciarBtn.ForeColor = Color.White;
            iniciarBtn.Location = new Point(225, 403);
            iniciarBtn.Margin = new Padding(2, 3, 2, 3);
            iniciarBtn.Name = "iniciarBtn";
            iniciarBtn.Size = new Size(170, 62);
            iniciarBtn.TabIndex = 7;
            iniciarBtn.Text = "Iniciar";
            iniciarBtn.UseVisualStyleBackColor = false;
            iniciarBtn.Click += iniciarBtn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(60, 110, 113);
            label4.Location = new Point(170, 126);
            label4.Name = "label4";
            label4.Size = new Size(116, 18);
            label4.TabIndex = 20;
            label4.Text = "Temperatura:";
            // 
            // txtTemp
            // 
            txtTemp.Location = new Point(170, 159);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(277, 25);
            txtTemp.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(60, 110, 113);
            label1.Location = new Point(170, 248);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 18;
            label1.Text = "Tempo (s):";
            // 
            // tempoTxt
            // 
            tempoTxt.Location = new Point(170, 279);
            tempoTxt.Name = "tempoTxt";
            tempoTxt.Size = new Size(277, 25);
            tempoTxt.TabIndex = 17;
            // 
            // tempLbl
            // 
            tempLbl.AutoSize = true;
            tempLbl.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tempLbl.ForeColor = Color.FromArgb(60, 110, 113);
            tempLbl.Location = new Point(301, 126);
            tempLbl.Name = "tempLbl";
            tempLbl.Size = new Size(0, 18);
            tempLbl.TabIndex = 21;
            // 
            // Iniciar
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 248);
            ClientSize = new Size(624, 601);
            Controls.Add(tempLbl);
            Controls.Add(label4);
            Controls.Add(txtTemp);
            Controls.Add(label1);
            Controls.Add(tempoTxt);
            Controls.Add(iniciarBtn);
            Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(60, 110, 113);
            Margin = new Padding(4);
            Name = "Iniciar";
            Text = "Iniciar";
            Load += Iniciar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button iniciarBtn;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private TextBox txtTemp;
        private Label label1;
        private TextBox tempoTxt;
        private Label tempLbl;
    }
}