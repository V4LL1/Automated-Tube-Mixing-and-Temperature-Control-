namespace tube_mixing_software
{
    partial class Historico
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
            historicoGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)historicoGrid).BeginInit();
            SuspendLayout();
            // 
            // historicoGrid
            // 
            historicoGrid.AllowUserToAddRows = false;
            historicoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historicoGrid.Location = new Point(12, 12);
            historicoGrid.Name = "historicoGrid";
            historicoGrid.ReadOnly = true;
            historicoGrid.Size = new Size(760, 591);
            historicoGrid.TabIndex = 0;
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 248);
            ClientSize = new Size(784, 615);
            Controls.Add(historicoGrid);
            Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(60, 110, 113);
            Margin = new Padding(4);
            Name = "Historico";
            Text = "Historico";
            Load += Historico_Load;
            ((System.ComponentModel.ISupportInitialize)historicoGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView historicoGrid;
    }
}