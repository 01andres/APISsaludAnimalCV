using APISsaludAnimalClnicaVeterinatia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace APISsaludAnimalClnicaVeterinatia.Data
{
    public class detalleServicioData
    {
        public static bool registardetalleServicio(detalleServicio oServicio)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            string fechaFormateada = oServicio.fechaServicio.ToString("yyyy-MM-dd");
            sentencia = "execute PA_insertar_detalleServicio '" + fechaFormateada+"','" + oServicio.nroCita + "','" + oServicio.idTipoServicio + "','"+oServicio.idNombreMascota+"'";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);


            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }


        }


        public static bool actualizardetalleServicio(detalleServicio oServicio)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            string fechaFormateada = oServicio.fechaServicio.ToString("yyyy-MM-dd HH:mm");
            sentencia = "execute PA_actualizar_detalleServicio'" + oServicio.idDetalleServicio + "','" + fechaFormateada + "','" + oServicio.nroCita + "','" + oServicio.idTipoServicio +"','"+oServicio.idNombreMascota + "'";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);


            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }


        }

        public static bool borrardetalleServicio(detalleServicio oServicio)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_borrar_detalleServicio'" + oServicio.idDetalleServicio + "'";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);


            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }


        }

        public static List<detalleServicio> Listar()
        {
            List<detalleServicio> oListarServicio = new List<detalleServicio>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_listar_detalleServicio";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarServicio.Add(new detalleServicio()
                    {
                        idDetalleServicio = Convert.ToInt32(dr["idDetalleServicio"]),
                        fechaServicio = Convert.ToDateTime(dr["fechaServicio"].ToString()),
                        nroCita = Convert.ToInt32(dr["nroCita"]),
                        idTipoServicio = Convert.ToInt32(dr["idTipoServicio"]),
                        idNombreMascota = dr["idNombreMascota"].ToString()


                    });

                }
                return oListarServicio;
            }
            else
            {
                return oListarServicio;
            }

        }

        public static List<detalleServicio> Consultar(string id)
        {
            List<detalleServicio> oListarServicio = new List<detalleServicio>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute [PA_consultar_detalleServicio]'" + id+"'";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarServicio.Add(new detalleServicio()
                    {
                        idDetalleServicio = Convert.ToInt32(dr["idDetalleServicio"]),
                        fechaServicio = Convert.ToDateTime(dr["fechaServicio"].ToString()),
                        nroCita = Convert.ToInt32(dr["nroCita"]),
                        idTipoServicio = Convert.ToInt32(dr["idTipoServicio"]),
                        idNombreMascota = dr["idNombreMascota"].ToString()

                    });

                }
                return oListarServicio;
            }
            else
            {
                return oListarServicio;
            }

        }




    }
}