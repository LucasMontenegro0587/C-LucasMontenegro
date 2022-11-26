using Proyecto_Lucas_Montenegro.Class;
using System.Data;
using System.Data.SqlClient;

namespace ConexionBaseDeDatos
{
    public class ConexionBaseDatos
    {
        private SqlConnection conexion;/*
        private String cadenaConexion = "Server=localhost\\SQLEXPRESS" +
            "Database=Proyecto;" +
            "User Id=Lucas;" +
            "Password=Prueba123;";*/
        private String cadenaConexion = "Server = PC-L\\SQLEXPRESS; Database=Proyecto;Trusted_Connection=True";
        
        public ConexionBaseDatos()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
            }
            catch (Exception ex)
            {

            }
        }

        public List<Usuario> listarUsuario()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.Id = (int)reader["Id"];
                                usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                                usuario.Contrasena = reader["Contrasena"].ToString();
                                usuario.FechaInsersion = reader["FechaInsersion"].ToString();
                                usuario.FechaActualizacion = reader["FechaActualizacion"].ToString();
                                lista.Add(usuario);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No tiene registros");
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception ex)
            {

            }
            return lista;
        }

        public int InsertarUsuario(Usuario usuario)
        {
            try
            {
                string query = "INSERT INTO Usuario (NombreUsuario, Contrasena, FechaInsersion, FechaActualizacion) " +
                    "VALUES (@NombreUsuario, @Contrasena, @FechaInsersion, @FechaActualizacion); SELECT @@IDENTITY;";
                conexion.Open();
                int ultimoIdInsertado = 0;
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    command.Parameters.Add(new SqlParameter("Contrasena", SqlDbType.VarChar) { Value = usuario.Contrasena });
                    command.Parameters.Add(new SqlParameter("FechaInsersion", SqlDbType.VarChar) { Value = usuario.FechaInsersion });
                    command.Parameters.Add(new SqlParameter("FechaActualizacion", SqlDbType.VarChar) { Value = usuario.FechaActualizacion });

                    /* Este método retorna las filas afectadas por la consulta */
                    //filasAfectadas = command.ExecuteNonQuery();

                    // Este método sirve para obtener un valor simple de la consulta realizada
                    ultimoIdInsertado = Convert.ToInt32(command.ExecuteScalar());
                    usuario.Id = ultimoIdInsertado;
                }
                conexion.Close();
                return ultimoIdInsertado;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int EliminarUsuario(int idUsuario)
        {
            try
            {
                string query = "DELETE FROM Usuario WHERE id = @idUsuario;";
                conexion.Open();
                int filasAfectadas = 0;
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.Add(new SqlParameter("idUsuario", SqlDbType.BigInt) { Value = idUsuario });
                    filasAfectadas = command.ExecuteNonQuery();
                }
                conexion.Close();
                return filasAfectadas;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int CambiarContrasena(int IdUsuario, string NuevaContrasena)
        {
            try
            {
                string query = "UPDATE Usuarios SET Contrasena = @contrasena WHERE UsuarioId = @idUsuario";
                conexion.Open();
                int filasAfectadas = 0;
                Console.WriteLine(NuevaContrasena);
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.Add(new SqlParameter("idUsuario", SqlDbType.Int) { Value = IdUsuario });
                    command.Parameters.Add(new SqlParameter("contrasena", SqlDbType.NVarChar) { Value = NuevaContrasena });
                    filasAfectadas = command.ExecuteNonQuery();
                }
                conexion.Close();
                return filasAfectadas;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}


