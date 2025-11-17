using System;
using WinFormsApp1.Classe;

namespace WinFormsApp1
{
    public partial class CadastrarCursos : Form
    {
        public CadastrarCursos()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                var cadastrarCurso = new Classe.CadastrarCursos(
                txtNome.Text,
                int.Parse(txtAno.Text),
                int.Parse(txtCargaHoraria.Text));

                cadastrarCurso.Cadastrar();
                MessageBox.Show("Aluno cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar curso: " + ex.Message);
            }
        }
    }
}
