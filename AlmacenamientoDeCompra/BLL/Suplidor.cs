using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Suplidor
    {
        public int CodigoSuplidor { get; set; }
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public String Celular { get; set; }
        public String Direcion { get; set; }
        public String Email { get; set; }

        Conexion conectar = new Conexion();

        public Suplidor(int CodigoSuplidor, String Nombre, String Telefono, String Celular, String Direcion, String Email)
        {

            this.CodigoSuplidor = CodigoSuplidor;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Celular = Celular;
            this.Direcion = Direcion;
            this.Email = Email;


        }

        public Suplidor()
        {
            // TODO: Complete member initialization
        }

        public bool Insertar()
        {
            return conectar.EjecutarDB("Insert Into Suplidores(Nombre,Telefono,Celular,Direcion,Email ) Values ('" +
                Nombre + "','" + Telefono + "','" + Celular + "','" + Direcion + "','" + Email + "')");
        }

        public bool Modificar(int CodigoSuplidor)
        {
            return conectar.EjecutarDB(" update Suplidores set CodigoSuplidor ='" + CodigoSuplidor +  "',Nombre ='" + Nombre + "',Telefono ='" + Telefono + "',Celular ='" + Celular + "',Direcion ='" + Direcion + "',Email ='" + Email + "' where CodigoSuplidor = '" + CodigoSuplidor + "' ");
        }

        public bool Eliminar(int CodigoSuplidor)
        {
            return conectar.EjecutarDB("Delete from Suplidores where CodigoSuplidor='" + CodigoSuplidor + "' ");
        }

        public bool Buscar(int CodigoSuplidor)
        {
            bool mensaje = false;


            DataTable dt;

            dt = conectar.BuscarDb("select * from Suplidores where CodigoSuplidor = " + CodigoSuplidor);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                this.CodigoSuplidor = (int)dt.Rows[0]["CodigoSuplidor"];
                this.Nombre = (String)dt.Rows[0]["Nombre"];
                this.Telefono = (String)dt.Rows[0]["Telefono"];
                this.Celular = (String)dt.Rows[0]["Celular"];
                this.Direcion = (String)dt.Rows[0]["Direcion"];
                this.Email = (String)dt.Rows[0]["Email"];


            }

            return mensaje;
        }
        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " From Suplidores Where " + FiltroWhere);
        }
    }

}   
    


