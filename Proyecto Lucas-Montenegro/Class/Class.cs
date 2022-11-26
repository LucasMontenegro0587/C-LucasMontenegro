using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lucas_Montenegro.Class
{
    public class Usuario
    {
        public int Id;
        public String NombreUsuario { get; set; }
        public String Contrasena { get; set; }
        public String FechaInsersion { get; set; }
        public String FechaActualizacion { get; set; }
        public Usuario(int id, string nombreUsuario, string contrasena, string fechaInsersion, string fechaActualizacion)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            FechaInsersion = fechaInsersion;
            FechaActualizacion = fechaActualizacion;
        }
        public Usuario() { }

    }
    public class Producto
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public int Costo { get; set; }
        public int PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
        public String FechaInsersion { get; set; }

        public String FechaActualizacion { get; set; }
    }
    public class ProductoVendido
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public int IdVenta { get; set; }
        public String FechaInsersion { get; set; }

        public String FechaActualizacion { get; set; }
    }
    public class Venta
    {
        public int Id { get; set; }
        public String Comentarios { get; set; }
        public int IdUsuario { get; set; }
        public String FechaInsersion { get; set; }
        public String FechaActualizacion { get; set; }
        public int Monto { get; set; }
    }
}