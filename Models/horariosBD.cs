using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSCHARP.Models
{
    internal class horariosBD
    {
        public string connectionString =
            "Data Source=DESKTOP-IVSD5AJ\\ALLANPRUEBAS;Initial Catalog=FundamentosCSHARP;Integrated Security=True";

        public void Add(horarios horario)
        {
            string query
                = "INSERT INTO horarios (curso, creditos, aula)" +
                "VALUES (@curso, @creditos, @aula)";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@curso", horario.curso);
                cmd.Parameters.AddWithValue("@creditos", horario.creditos);
                cmd.Parameters.AddWithValue("@aula", horario.aula);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
