using MySql.Data.MySqlClient;

namespace WinFormsApp1.Classe
{
    internal class CadastrarCursoDB
    {
        private readonly static string ConnectionString =
            "server=localhost;user=root;password=;database=Escola";

        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int Ano { get; set; }

        public CadastrarCursoDB(string nome, int cargaHoraria, int ano)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            Ano = ano;
        }

        public void Cadastrar() 
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                string query = @"INSERT INTO Cursos
                    (Nome, CargaHoraria, Ano)
                    VALUES
                    (@Nome, @CargaHoraria, @Ano)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@CargaHoraria", CargaHoraria);
                    cmd.Parameters.AddWithValue("@Ano", Ano);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
