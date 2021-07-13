using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class DataAccessLayer
    {
        public SqlConnection conn = new SqlConnection("Data Source=LAPTOP-3ADCGICH\\MSSQLSERVER01;Initial Catalog=BDTutoria;Integrated Security=True");
        public void InsertarTutor(Tutor tutor)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO Tutores(ID_tutor, Nombres, Apellido_Paterno, Apellido_Materno, Titulo_academico)
                                VALUES(@ID_tutor, @Nombres, @Apellido_Paterno, @Apellido_Materno, @Titulo_academico)";
                SqlParameter ID_tutor = new SqlParameter("@ID_tutor", tutor.Id_tutor);
                SqlParameter Nombres = new SqlParameter("@Nombres", tutor.Nombres);
                SqlParameter Apellido_Paterno = new SqlParameter("@Apellido_Paterno", tutor.Apellido_Paterno);
                SqlParameter Apellido_Materno = new SqlParameter("@Apellido_Materno", tutor.Apellido_Materno);
                SqlParameter Titulo_academico = new SqlParameter("@Titulo_academico", tutor.Titulo_Academico);

                SqlCommand comand = new SqlCommand(query, conn);
                comand.Parameters.Add(ID_tutor);
                comand.Parameters.Add(Nombres);
                comand.Parameters.Add(Apellido_Paterno);
                comand.Parameters.Add(Apellido_Materno);
                comand.Parameters.Add(Titulo_academico);

                comand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public void ActualizarTutor(Tutor tutor)
        {
            try
            {
                conn.Open();
                string query = @" UPDATE Tutores
                                SET Nombres=@Nombres,
                                    Apellido_Paterno=@Apellido_Paterno,
                                    Apellido_Materno=@Apellido_Materno,
                                    Titulo_academico=@Titulo_academico
                                WHERE ID_tutor=@ID_tutor";
                SqlParameter ID_tutor = new SqlParameter("@ID_tutor", tutor.Id_tutor);
                SqlParameter Nombres = new SqlParameter("@Nombres", tutor.Nombres);
                SqlParameter Apellido_Paterno = new SqlParameter("@Apellido_Paterno", tutor.Apellido_Paterno);
                SqlParameter Apellido_Materno = new SqlParameter("@Apellido_Materno", tutor.Apellido_Materno);
                SqlParameter Titulo_academico = new SqlParameter("@Titulo_academico", tutor.Titulo_Academico);

                SqlCommand comand = new SqlCommand(query, conn);
                comand.Parameters.Add(ID_tutor);
                comand.Parameters.Add(Nombres);
                comand.Parameters.Add(Apellido_Paterno);
                comand.Parameters.Add(Apellido_Materno);
                comand.Parameters.Add(Titulo_academico);

                comand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public void ElimnarTutor(string ID_tutor)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM Tutores WHERE ID_tutor=@ID_tutor";
                SqlCommand comand = new SqlCommand(query, conn);
                comand.Parameters.Add(new SqlParameter("@ID_tutor", ID_tutor));

                comand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<Tutor> GetTutores(string texto_buscar=null)
        {
            List<Tutor> tutores = new List<Tutor>();
            try
            {
                conn.Open();
                string query = @"SELECT ID_tutor, Nombres, Apellido_Paterno, Apellido_Materno, Titulo_academico
                                FROM Tutores ";
                SqlCommand comand = new SqlCommand();

                if (!string.IsNullOrEmpty(texto_buscar))
                {
                    query += @"WHERE ID_tutor LIKE @texto_buscar OR Nombres LIKE @texto_buscar OR Apellido_Paterno LIKE @texto_buscar OR 
                                Apellido_Materno LIKE @texto_buscar OR Titulo_academico LIKE @texto_buscar ";

                    comand.Parameters.Add(new SqlParameter("@texto_buscar", $"%{texto_buscar}%"));
                }
                comand.CommandText = query;
                comand.Connection = conn;
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    tutores.Add(new Tutor
                    {
                        Id_tutor = reader["ID_tutor"].ToString(),
                        Nombres = reader["Nombres"].ToString(),
                        Apellido_Paterno = reader["Apellido_Paterno"].ToString(),
                        Apellido_Materno = reader["Apellido_Materno"].ToString(),
                        Titulo_Academico = reader["Titulo_academico"].ToString(),
                    });

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return tutores;
        }
        
    }
}
