using MySql.Data.MySqlClient;
using WinFormsApp1.Model;
using System.Collections.Generic;

namespace WinFormsApp1.Classe
{
    internal class CarregarDados
    {
        private readonly static string ConnectionString =
            "server=localhost;user=root;password=;database=Escola";

        public List<AlunoModel> DadosAlunos()
        {
            var lista = new List<AlunoModel>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Alunos";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new AlunoModel
                            {
                                AlunoId = reader.GetInt32("AlunoId"),
                                Nome = reader.GetString("Nome"),
                                Nascimento = reader.GetDateTime("Nascimento"),
                                Sexo = reader.GetString("Sexo"),
                                Cidade = reader.GetString("Cidade"),
                                Nacionalidade = reader.GetString("Nacionalidade")
                            });
                        }
                    }
                }
            }
            return lista;
        }


        public List<CursoModel> DadosCursos() 
        { 
            var lista = new List<CursoModel>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Cursos";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
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
