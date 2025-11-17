namespace WinFormsApp1
{
    partial class MenuPricipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            formTestToolStripMenuItem = new ToolStripMenuItem();
            formCadastroToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCursoToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            empilhadoToolStripMenuItem = new ToolStripMenuItem();
            exibirToolStripMenuItem = new ToolStripMenuItem();
            fecharAbasToolStripMenuItem = new ToolStripMenuItem();
            minimizarAbasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, cursosToolStripMenuItem, abrirToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "Alunos";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formTestToolStripMenuItem, formCadastroToolStripMenuItem, cadastrarCursoToolStripMenuItem });
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // formTestToolStripMenuItem
            // 
            formTestToolStripMenuItem.Name = "formTestToolStripMenuItem";
            formTestToolStripMenuItem.Size = new Size(180, 22);
            formTestToolStripMenuItem.Text = "Login";
            formTestToolStripMenuItem.Click += formTestToolStripMenuItem_Click;
            // 
            // formCadastroToolStripMenuItem
            // 
            formCadastroToolStripMenuItem.Name = "formCadastroToolStripMenuItem";
            formCadastroToolStripMenuItem.Size = new Size(180, 22);
            formCadastroToolStripMenuItem.Text = "Cadastro";
            formCadastroToolStripMenuItem.Click += formCadastroToolStripMenuItem_Click;
            // 
            // cadastrarCursoToolStripMenuItem
            // 
            cadastrarCursoToolStripMenuItem.Name = "cadastrarCursoToolStripMenuItem";
            cadastrarCursoToolStripMenuItem.Size = new Size(180, 22);
            cadastrarCursoToolStripMenuItem.Text = "Cadastrar Curso";
            cadastrarCursoToolStripMenuItem.Click += cadastrarCursoToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { horizontalToolStripMenuItem, verticalToolStripMenuItem, empilhadoToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(129, 22);
            horizontalToolStripMenuItem.Text = "Horizontal";
            horizontalToolStripMenuItem.Click += horizontalToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(129, 22);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // empilhadoToolStripMenuItem
            // 
            empilhadoToolStripMenuItem.Name = "empilhadoToolStripMenuItem";
            empilhadoToolStripMenuItem.Size = new Size(129, 22);
            empilhadoToolStripMenuItem.Text = "Cascata";
            empilhadoToolStripMenuItem.Click += empilhadoToolStripMenuItem_Click;
            // 
            // exibirToolStripMenuItem
            // 
            exibirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fecharAbasToolStripMenuItem, minimizarAbasToolStripMenuItem });
            exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            exibirToolStripMenuItem.Size = new Size(48, 20);
            exibirToolStripMenuItem.Text = "Exibir";
            // 
            // fecharAbasToolStripMenuItem
            // 
            fecharAbasToolStripMenuItem.Name = "fecharAbasToolStripMenuItem";
            fecharAbasToolStripMenuItem.Size = new Size(156, 22);
            fecharAbasToolStripMenuItem.Text = "Fechar Abas";
            fecharAbasToolStripMenuItem.Click += fecharAbasToolStripMenuItem_Click;
            // 
            // minimizarAbasToolStripMenuItem
            // 
            minimizarAbasToolStripMenuItem.Name = "minimizarAbasToolStripMenuItem";
            minimizarAbasToolStripMenuItem.Size = new Size(156, 22);
            minimizarAbasToolStripMenuItem.Text = "Minimizar Abas";
            minimizarAbasToolStripMenuItem.Click += minimizarAbasToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, exibirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(867, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(180, 22);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // MenuPricipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 484);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuPricipal";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripMenuItem empilhadoToolStripMenuItem;
        private ToolStripMenuItem exibirToolStripMenuItem;
        private ToolStripMenuItem fecharAbasToolStripMenuItem;
        private ToolStripMenuItem minimizarAbasToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem formTestToolStripMenuItem;
        private ToolStripMenuItem formCadastroToolStripMenuItem;
        private ToolStripMenuItem cadastrarCursoToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
    }
}
