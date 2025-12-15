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
            Alunos alunos = new Alunos();
            alunos.MdiParent = this;
            alunos.Show();
        }

        private void formCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarAlunos cadastro = new CadastrarAlunos();
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
            CadastrarCursos curso = new CadastrarCursos();
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
