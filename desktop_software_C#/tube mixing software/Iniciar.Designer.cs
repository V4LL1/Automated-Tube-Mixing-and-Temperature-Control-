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
            tempTxt = new TextBox();
            label1 = new Label();
            tempoTxt = new TextBox();
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
            // tempTxt
            // 
            tempTxt.Location = new Point(170, 159);
            tempTxt.Name = "tempTxt";
            tempTxt.Size = new Size(277, 25);
            tempTxt.TabIndex = 19;
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
            // Iniciar
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 248);
            ClientSize = new Size(624, 601);
            Controls.Add(label4);
            Controls.Add(tempTxt);
            Controls.Add(label1);
            Controls.Add(tempoTxt);
            Controls.Add(iniciarBtn);
            Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(60, 110, 113);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Iniciar";
            Text = "Iniciar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button iniciarBtn;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private TextBox tempTxt;
        private Label label1;
        private TextBox tempoTxt;
    }
}