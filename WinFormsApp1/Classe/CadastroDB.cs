using System;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.Classe
{
    internal class CadastroDB
    {
        private static readonly string ConnectionString =
            "server=localhost;user=root;password=;database=Escola";

        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }
        public string Cidade { get; set; }
        public string Nacionalidade { get; set; }

        public CadastroDB(string nome, DateTime nascimento, string sexo, string cidade, string nacionalidade)
        {
            Nome = nome;
            Nascimento = nascimento;
            Sexo = sexo;
            Cidade = cidade;
            Nacionalidade = nacionalidade;
        }

        public void CadastrarAluno()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                string query = @"
                    INSERT INTO Alunos 
                    (Nome, Nascimento, Sexo, Cidade, Nacionalidade)
                    VALUES
                    (@Nome, @Nascimento, @Sexo, @Cidade, @Nacionalidade)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Nascimento", Nascimento.Date);
                    cmd.Parameters.AddWithValue("@Sexo", Sexo);
                    cmd.Parameters.AddWithValue("@Cidade", Cidade);
                    cmd.Parameters.AddWithValue("@Nacionalidade", Nacionalidade);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
