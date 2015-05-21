﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class Producto
    {
        public int CodigoProducto { get; set; }
        public String NombreProductos { get; set; }
        public double CostoProductos { get; set; }
        public double PrecioProductos { get; set; }
        public int Existencia { get; set; }

        Conexion conectar = new Conexion();


        public Producto(int CodigoProducto, String NombreProductos, double CostoProductos, double PrecioProducto, int Existencia)
        {
            this.CodigoProducto = CodigoProducto;
            this.NombreProductos = NombreProductos;
            this.CostoProductos = CostoProductos;
            this.PrecioProductos = PrecioProductos;
            this.Existencia = Existencia;
        }

        public Producto()
        {
            // TODO: Complete member initialization
        }

        public bool Insertar()
        {
            return conectar.EjecutarDB("Insert Into Productos(NombreProductos ,CostoProductos,PrecioProductos,Existencias ) Values ('" +
                  NombreProductos  + "','" + CostoProductos + "','" + PrecioProductos + "','" + Existencia + "')");
        }

        public bool Modificar(int CodigoProducto)
        {
            return conectar.EjecutarDB(" update Productos set CodigoProducto ='" + CodigoProducto + "',NombreProductos = '" + NombreProductos + "',CostoProductos ='" + CostoProductos + "',PrecioProductos ='" + PrecioProductos + "',Existencia ='" + Existencia + "' where CodigoProducto = '" + CodigoProducto + "' ");
        }

        public bool Eliminar(int CodigoProducto)
        {
            return conectar.EjecutarDB("Delete from Productos where CodigoProducto='" + CodigoProducto + "' ");
        }

        public bool Buscar(int CodigoProducto)
        {
            bool mensaje = false;


            DataTable dt;

            dt = conectar.BuscarDb("select * from Productos where CodigoProducto = " + CodigoProducto);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                CodigoProducto = (int)dt.Rows[0]["CodigoProducto"];
                NombreProductos = (String)dt.Rows[0]["NombreProductos"];
                CostoProductos = (double)dt.Rows[0]["CostoProductos"];
                PrecioProductos = (double)dt.Rows[0]["PrecioProductos"];
                Existencia = (int)dt.Rows[0]["Existencias"];



            }

            return mensaje;
        }
        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + "From Productos Where " + FiltroWhere);
        }

        public static bool AumentarExistenciaProducto(string CodigoProducto, int Existencia)
        {
            Conexion conectar = new Conexion();
            return conectar.EjecutarDB(" update Productos set Existencias +=" + Existencia + " Where CodigoProducto = " + CodigoProducto);
        }
    }

}