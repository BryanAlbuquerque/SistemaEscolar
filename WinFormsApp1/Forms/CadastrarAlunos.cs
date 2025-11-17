using System;
using WinFormsApp1.Classe;

namespace WinFormsApp1
{
    public partial class CadastrarAlunos : Form
    {
        public CadastrarAlunos()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                var aluno = new Classe.CadastrarAlunos(
                txtNome.Text,
                DateTime.Parse(txtData.Text),
                txtSexo.Text,
                txtCidade.Text,
                txtNacionalidade.Text);

                aluno.CadastrarAluno();
                MessageBox.Show("Aluno cadastrado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
