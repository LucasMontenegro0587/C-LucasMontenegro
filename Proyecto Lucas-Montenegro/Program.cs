// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
Console.WriteLine("30");
string PrimeraVariable = "GoldenFreezer";
Console.WriteLine(PrimeraVariable);
int VariableNumerica = 50;
int VariableNumericaDos = 75;
Console.WriteLine(VariableNumerica + VariableNumericaDos);
VariableNumerica = 60;
Console.WriteLine(VariableNumerica);
Console.WriteLine("Hola");*/

using Proyecto_Lucas_Montenegro.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConexionBaseDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empezando la consulta");
            ConexionBaseDatos baseDatos = new ConexionBaseDatos();
            Usuario usuarioActualizar = new Usuario(1, "Pepe", "Lucas", "26/11", "26/11");
            usuarioActualizar.Contrasena = "EstaContraseñaFueCambiada";
            int filasAfectadas = baseDatos.CambiarContrasena(1, "NuevaContraseñaActualizada");
            if (filasAfectadas != 0)
            {
                Console.WriteLine("Actualizado correctamente");
            }
            else
            {
                Console.WriteLine("Ocurrió un error o el ID no existe");
            }
            
            Console.WriteLine("Terminando la consulta");
        }
        /*
        static void CreandoConsultas()
        {
            String connectionString = "Server=sql.bsite.net\\MSSQL2016;" +
                "Database=ajomuch92_coderhouse_csharp_40930;" +
                "User Id=ajomuch92_coderhouse_csharp_40930;" +
                "Password=ElQuequit0Sexy2022;";
            try
            {
                Console.WriteLine("Creando la conexión");
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE id=@id", sqlConnection))
                    {
                        SqlParameter sqlParameter = new SqlParameter();
                        sqlParameter.ParameterName = "id";
                        sqlParameter.DbType = DbType.Int64;
                        sqlParameter.Value = 1;
                        cmd.Parameters.Add(sqlParameter);
                        sqlConnection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine(reader.GetInt64(0));
                                    Console.WriteLine(reader.GetString(1));
                                }
                            }
                            else
                            {
                                Console.WriteLine("No tiene registros...");
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ConsultandoProductos()
        {
            String connectionString = "Server=sql.bsite.net\\MSSQL2016;" +
                "Database=ajomuch92_coderhouse_csharp_40930;" +
                "User Id=ajomuch92_coderhouse_csharp_40930;" +
                "Password=ElQuequit0Sexy2022;";
            List<Producto> listaProductos = new List<Producto>();
            try
            {
                Console.WriteLine("Creando la conexión");
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    string query = "SELECT codigo, descripcion, precioCompra, precioVenta, categoria FROM productos";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Producto producto = new Producto();
                                    producto.Codigo = Convert.ToInt64(reader["codigo"]);
                                    producto.Descripcion = reader["descripcion"].ToString();
                                    producto.PrecioVenta = Convert.ToDouble(reader["precioVenta"].ToString());
                                    producto.PrecioCompra = Convert.ToDouble(reader["precioCompra"].ToString());
                                    producto.Categoria = reader["categoria"].ToString();
                                    listaProductos.Add(producto);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No tiene registros...");
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        */
    }
}
