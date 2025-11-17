namespace WinFormsApp1
{
    partial class Alunos
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
            label1 = new Label();
            txtPesquisa = new TextBox();
            btnPesquisa = new Button();
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
            dtGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar no Banco de dados";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(12, 78);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(375, 23);
            txtPesquisa.TabIndex = 2;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(393, 77);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(75, 23);
            btnPesquisa.TabIndex = 3;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // Alunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPesquisa);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(dtGrid);
            Name = "Alunos";
            Text = "Padrão";
            Load += Padrao_Load;
            ((System.ComponentModel.ISupportInitialize)dtGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGrid;
        private Label label1;
        private TextBox txtPesquisa;
        private Button btnPesquisa;
    }
}