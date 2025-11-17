using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class MenuPricipal : Form
    {
        public MenuPricipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alunos formPadrao = new Alunos();
            formPadrao.MdiParent = this;
            formPadrao.Show();
        }

        private void formTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.MdiParent = this;
            formLogin.Show();
        }

        private void formCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void empilhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void fecharAbasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void minimizarAbasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void cadastrarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCurso curso = new CadastrarCurso();
            curso.MdiParent = this;
            curso.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos cursos = new Cursos();
            cursos.MdiParent = this;
            cursos.Show();
        }
    }
}
