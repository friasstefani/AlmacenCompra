using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    class Pagos
    {
        public int CodigoPago { get; set; }
        public DateTime Fecha { get; set; }
        public int CodigoCompra { get; set; }
        public int Descuento { get; set; }
        public int Mora { get; set; }
        Conexion conectar = new Conexion();

        public Pagos(int CodigoPago, DateTime Fecha, int CodigoCompra, int Descuento, int Mora)
        {

            this.CodigoPago = CodigoPago;
            this.Fecha = Fecha;
            this.CodigoCompra = CodigoCompra;
            this.Descuento = Descuento;
            this.Mora = Mora;
        }
        public bool Insertar()
        {
            return conectar.EjecutarDB("Insert Into Pagos (CodigoPago,Fecha ,CodigoCompra,Descuento, Mora) Values ('" + CodigoPago +
                Fecha.Month + "/" + Fecha.Day + "/" + Fecha.Year + "','" + CodigoCompra + "','" + Descuento + "','" + Mora + "')");
        }

        public bool Modificar(int CodigoPago)
        {
            return conectar.EjecutarDB(" update Pagos set CodigoPago ='" + CodigoPago + "',Fecha = '" + Fecha.ToString("MM/dd/yyyy") + "',CodigoCompra ='" + CodigoCompra + "',Descuento ='" + Descuento + "',Mora ='" + Mora + "' where CodigoPago = '" + CodigoPago + "' ");
        }

        public bool Eliminar(int CodigoPago)
        {
            return conectar.EjecutarDB("Delete from Pagos where CodigoPago ='" + CodigoPago + "' ");
        }

        public bool Buscar(int CodigoPago)
        {
            bool mensaje = false;


            DataTable dt;

            dt = conectar.BuscarDb("select * from Pago where CodigoPago = " + CodigoPago);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                CodigoPago = (int)dt.Rows[0]["CodigoPago"];
                Fecha = (DateTime)dt.Rows[0]["Fecha"];
                CodigoCompra = (int)dt.Rows[0]["CodigoCompra"];
                Descuento = (int)dt.Rows[0]["Descuento"];
                Mora = (int)dt.Rows[0]["Mora"];


            }

            return mensaje;
        }
        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + "From Pagos Where " + FiltroWhere);
        }
    }

}
