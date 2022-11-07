using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lucas_Montenegro.Class
{
    public class Usuario
    {
        int Id;
        String Nombre;
        String Apellido;
        String NombreUsuario;
        String Contraseña;
        String Mail;
    }
    public class Producto
    {
        int Id;
        String Descripcion;
        int Costo;
        int PrecioVenta;
        int Stock;
        int IdUsuario;
    }
    public class ProductoVendido
    {
        int Id;
        int IdProducto;
        int Stock;
        int IdVenta;
    }
    public class Venta
    {
        int Id;
        String Comentarios;
    }
}