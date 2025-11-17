using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Classe;

namespace WinFormsApp1.Forms
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            CarregarDados carregar = new Classe.CarregarDados();
            dtGrid.DataSource = carregar.DadosCursos();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisa.Text.Trim();

            Pesquisar buscar = new Pesquisar();
            dtGrid.DataSource = buscar.BuscarCursos(termo);

        }
    }
}
