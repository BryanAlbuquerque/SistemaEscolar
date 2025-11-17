using WinFormsApp1.Classe;

namespace WinFormsApp1
{
    public partial class Alunos : Form
    {
        public Alunos()
        {
            InitializeComponent();
        }

        private void Padrao_Load(object sender, EventArgs e)
        {
            CarregarDados dados = new CarregarDados();
            dtGrid.DataSource = dados.DadosAlunos();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisa.Text.Trim();

            Pesquisar buscar = new Pesquisar();
            var dados = buscar.BuscarAlunos(termo);

            dtGrid.DataSource = dados;
        }
    }
}
