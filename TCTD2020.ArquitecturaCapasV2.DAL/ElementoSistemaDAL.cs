using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV2.BE;


namespace TCTD2020.ArquitecturaCapasV2.DAL
{
    internal class ElementoSistemaDAL
    {
        string connectionString = "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;";

        public ElementoSistema GetRoot() {

            string query = "SELECT * FROM Directorio2 WHERE IdPadre IS NULL";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    return null;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found.");
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ElementoSistema SaveFile(ElementoSistema elemento)
        {

            string query = "INSERT INTO Directorio2 WHERE IdPadre IS NULL";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    return null;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }



    }
}
