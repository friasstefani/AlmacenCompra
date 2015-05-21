using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class Compras
    {
        public int CodigoCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int CodigoSuplidor { get; set; }
        public int TotalCompras { get; set; }

        Conexion conectar = new Conexion();

        public Compras(int CodigoCompra, DateTime Fecha, int CodigoSuplidor, int TotalCompras)
        {

            this.CodigoCompra = CodigoCompra;
            this.Fecha = Fecha;
            this.CodigoSuplidor = CodigoSuplidor;
            this.TotalCompras = TotalCompras;
        }

        public Compras()
        {
            // TODO: Complete member initialization
        }

        public bool Insertar()
        {
            bool inserto = conectar.EjecutarDB("Insert Into Compras (Fecha ,CodigoSuplidor,TotalCompra) Values ('" + 
                Fecha.Month + "/" + Fecha.Day + "/" + Fecha.Year + "','" + CodigoSuplidor + "','" + TotalCompras + "')");
            return inserto;
        }

        public bool Modificar(int CodigoCompra)
        {
            return conectar.EjecutarDB(" update Compras set " + "'Fecha = '" + Fecha.ToString("MM/dd/yyyy") + "',CodigoSuplidor ='" + CodigoSuplidor + "',TotalCompras ='" + TotalCompras + "' where CodigoCompra = '" + CodigoCompra + "' ");
        }

        public bool Eliminar(int CodigoCompra)
        {
            return conectar.EjecutarDB("Delete from Compras where CodigoCompra='" + CodigoCompra + "' ");
        }

        public bool Buscar(int CodigoCompra)
        {
            bool mensaje = false;


            DataTable dt;

            dt = conectar.BuscarDb("select * from Compras where CodigoCompra = " + CodigoCompra);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                this.CodigoCompra = (int)dt.Rows[0]["CodigoCompra"];
                Fecha = (DateTime)dt.Rows[0]["Fecha"];
                CodigoSuplidor = (int)dt.Rows[0]["CodigoSuplidor"];
                TotalCompras = (int)dt.Rows[0]["TotalCompra"];


            }

            return mensaje;
        }
        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + "From Compras Where " + FiltroWhere);
        }

        public static int BuscarTotalCompra(String CodigoCompra)
        {
            int Total = 0;

            Conexion conectar = new Conexion();
            DataTable dt = conectar.BuscarDb("select Productos.PrecioProductos * DetallesCompras.CantidadProductos  as TotalCompra from " +
                                             "DetallesCompras inner join Productos  ON Productos.CodigoProducto = " +
                                             "DetallesCompras.CodigoProducto WHERE DetallesCompras.CodigoCompra = " + CodigoCompra);
            for (int x = 0; x <= dt.Rows.Count - 1;x++ )
            {
                int numero = 0;
                int.TryParse(dt.Rows[x]["TotalCompra"].ToString(), out numero);
                Total += numero;
            }
            conectar.EjecutarDB("update Compras SET TotalCompra = "+ Total + " Where CodigoCompra = " + CodigoCompra);

            return Total;
        }
    }

}