using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class DetallesCompras
    {
        public int CodigoCompra { get; set; }
        public int CantidadProductos { get; set; }
        public int CodigoProducto { get; set; }

        Conexion conectar = new Conexion();

        public DetallesCompras(int CodigoCompra, int CantidadProductos, int CodigoProducto)
        {

            this.CodigoCompra = CodigoCompra;
            this.CantidadProductos = CantidadProductos;
            this.CodigoProducto = CodigoProducto;
        }

        public DetallesCompras()
        {
            // TODO: Complete member initialization
        }

        public bool Insertar()
        {
            return conectar.EjecutarDB("Insert Into DetallesCompras (CodigoCompra,CantidadProductos ,CodigoProducto) Values ('" + CodigoCompra +
                  "','" + CantidadProductos + "','" + CodigoProducto + "')");
        }

        public bool Modificar(int CodigoCompra)
        {
            return conectar.EjecutarDB(" update DetallesCompras set CodigoCompra ='" + CodigoCompra + "',CantidadProductos ='" + CantidadProductos + "',CodigoProducto ='" + CodigoProducto + "' ");
        }

        public bool Eliminar(int CodigoCompra)
        {
            //cuando se va a eliminar un detalle de una compra, se llama la funcion reducir existencia 
            //para bajarle la existencia al producto
            Buscar(CodigoCompra);
            Producto.ReducirExistenciaProducto(this.CodigoProducto.ToString(), this.CantidadProductos);
            return conectar.EjecutarDB("Delete from DetallesCompras where CodigoCompra='" + CodigoCompra + "' ");
        }

        public bool Buscar(int CodigoCompra)
        {
            bool mensaje = false;


            DataTable dt;

            dt = conectar.BuscarDb("select * from DetallesCompras where CodigoCompra = " + CodigoCompra);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                this.CodigoCompra = (int)dt.Rows[0]["CodigoCompra"];
                CantidadProductos = (int)dt.Rows[0]["CantidadProductos"];
                CodigoProducto = (int)dt.Rows[0]["CodigoProducto"];
            }

            return mensaje;
        }
        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + "From DetallesCompras Where " + FiltroWhere);
        }

        /// <summary>
        /// funcion usada para validar si un producto tiene compras realizadas, para evitar borrarlo
        /// </summary>
        /// <param name="CodigoProducto">producto que desea buscar</param>
        /// <returns>retorna true si el producto posee compras</returns>
        public static bool ConsultarProducto(int CodigoProducto)
        {
            Conexion ConexionDB = new Conexion();
            DataTable dt = new DataTable();
            bool p = false;
            dt = ConexionDB.BuscarDb("select * from DetallesCompras where CodigoProducto = " + CodigoProducto);
            if (dt.Rows.Count > 0)
            {
                p = true;
            }

            return p;
        }
        /// <summary>
        /// funcion usada para validar si un suplidor posee compras, para evitar eliminarlo 
        /// </summary>
        /// <param name="CodigoSuplidor">codigo del suplidor que desea buscar</param>
        /// <returns>retorna true si posee compras</returns>
        public static bool ConsultarSuplidor(int CodigoSuplidor)
        {
            Conexion ConexionDB = new Conexion();
            DataTable dt = new DataTable();
            bool s = false;
            dt = ConexionDB.BuscarDb("select * from Compras where CodigoSuplidor = " + CodigoSuplidor);
            if (dt.Rows.Count > 0)
            {
                s = true;
            }

            return s;
        }




    }

}