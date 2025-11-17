using System;
using WinFormsApp1.Classe;

namespace WinFormsApp1
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                var aluno = new CadastroDB(
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
