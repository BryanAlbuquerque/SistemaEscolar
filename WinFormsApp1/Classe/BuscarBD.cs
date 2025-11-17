using MySql.Data.MySqlClient;
using WinFormsApp1.Model;

namespace WinFormsApp1.Classe
{
    internal class BuscarBD
    {
        private readonly static string ConnectionString =
            "server=localhost;user=root;password=;database=Escola";

        public List<AlunoModel> BuscarAlunos(string termo)
        {
            var lista = new List<AlunoModel>();
            string query = @"SELECT * FROM Alunos
            WHERE 
            Nome LIKE @Termo OR
            Cidade LIKE @Termo OR
            Nacionalidade LIKE @Termo OR
            DATE_FORMAT(Nascimento, '%d/%m/%Y') LIKE @Termo OR
            YEAR(Nascimento) LIKE @Termo";

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Termo", "%" + termo + "%");

                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new AlunoModel
                            {
                                Nome = reader.GetString("Nome"),
                                Nascimento = reader.GetDateTime("Nascimento"),
                                Cidade = reader.GetString("Cidade"),
                                Nacionalidade = reader.GetString("Nacionalidade")
                            });
                        }
                    }
                }
            }

            return lista;
        }


        public List<CursoModel> BuscarCursos(string termo)
        {
            var lista = new List<CursoModel>();

            string query = @"SELECT * FROM Cursos
            WHERE 
            Nome LIKE @Termo OR
            CAST(CargaHoraria AS CHAR) LIKE @Termo OR
            CAST(Ano AS CHAR) LIKE @Termo";

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Termo", "%" + termo + "%");

                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CursoModel
                            {
                                CursoId = reader.GetInt32("CursoId"),
                                Nome = reader.GetString("Nome"),
                                CargaHoraria = reader.GetInt32("CargaHoraria"),
                                Ano = reader.GetInt32("Ano")
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
