namespace WinFormsApp1
{
    partial class Cadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtData = new TextBox();
            txtSexo = new TextBox();
            txtCidade = new TextBox();
            txtNacionalidade = new TextBox();
            btnCadastro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 39);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 39);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 39);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Data Nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 128);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 128);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 4;
            label5.Text = "Nacionalidade";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 5;
            // 
            // txtData
            // 
            txtData.Location = new Point(179, 57);
            txtData.Name = "txtData";
            txtData.Size = new Size(100, 23);
            txtData.TabIndex = 6;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(354, 57);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(100, 23);
            txtSexo.TabIndex = 7;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(21, 146);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 8;
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Location = new Point(179, 146);
            txtNacionalidade.Name = "txtNacionalidade";
            txtNacionalidade.Size = new Size(100, 23);
            txtNacionalidade.TabIndex = 9;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(354, 120);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(100, 49);
            btnCadastro.TabIndex = 10;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastro);
            Controls.Add(txtNacionalidade);
            Controls.Add(txtCidade);
            Controls.Add(txtSexo);
            Controls.Add(txtData);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtData;
        private TextBox txtSexo;
        private TextBox txtCidade;
        private TextBox txtNacionalidade;
        private Button btnCadastro;
    }
}