namespace WinFormsApp1
{
    partial class CadastrarCursos
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
            btnCadastro = new Button();
            txtAno = new TextBox();
            txtCargaHoraria = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(323, 203);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(100, 49);
            btnCadastro.TabIndex = 17;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(500, 115);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 16;
            // 
            // txtCargaHoraria
            // 
            txtCargaHoraria.Location = new Point(336, 115);
            txtCargaHoraria.Name = "txtCargaHoraria";
            txtCargaHoraria.Size = new Size(100, 23);
            txtCargaHoraria.TabIndex = 15;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(167, 115);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 97);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 13;
            label3.Text = "Carga Horaria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 97);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 12;
            label2.Text = "Ano";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 97);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 11;
            label1.Text = "Nome";
            // 
            // CadastrarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastro);
            Controls.Add(txtAno);
            Controls.Add(txtCargaHoraria);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastrarCurso";
            Text = "CadastrarCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastro;
        private TextBox txtAno;
        private TextBox txtCargaHoraria;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}