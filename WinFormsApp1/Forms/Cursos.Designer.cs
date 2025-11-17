namespace WinFormsApp1.Forms
{
    partial class Cursos
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
            dtGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtGrid).BeginInit();
            SuspendLayout();
            // 
            // dtGrid
            // 
            dtGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid.Location = new Point(12, 117);
            dtGrid.Name = "dtGrid";
            dtGrid.ReadOnly = true;
            dtGrid.Size = new Size(776, 321);
            dtGrid.TabIndex = 1;
            // 
            // Cursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtGrid);
            Name = "Cursos";
            Text = "Cursos";
            Load += Cursos_Load;
            ((System.ComponentModel.ISupportInitialize)dtGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtGrid;
    }
}