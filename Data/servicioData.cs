using APISsaludAnimalClnicaVeterinatia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APISsaludAnimalClnicaVeterinatia.Data
{
    public class servicioData
    {
        public static bool registrarServicio(servicio oServicio) 
        {
            ConexionBD objEst = new ConexionBD(); 
            string sentencia;
            sentencia = "execute PA_insertar_Servicio'" + oServicio.idServicio + "','" + oServicio.nombreServicio + "'";

            if(!objEst.EjecutarSentencia(sentencia,false ))
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


        public static bool actualizarServicio(servicio oServicio)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_actualizar_Servicio'" + oServicio.idServicio + "','" + oServicio.nombreServicio + "','" + oServicio.precioServicio + "'";

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

        public static bool borrarServicio(servicio oServicio)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_borrar_Servicio'" + oServicio.idServicio +  "'";

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

        public static List<servicio>Listar()
        {
            List<servicio> oListarTipoServicio= new List<servicio>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_listar_Servicio";

            if(objEst.Consultar(sentencia,false))
            {
                SqlDataReader dr =objEst.Reader;
                while (dr.Read()) 
                {
                    oListarTipoServicio.Add(new servicio()
                    {
                        idServicio = Convert.ToInt32(dr["idServicio"]),
                        nombreServicio = dr["nombreServicio"].ToString(),
                        precioServicio = dr["precioServicio"].ToString()

                    });

                }
                return oListarTipoServicio;
            }
            else
            {
                return oListarTipoServicio;
            }
        }

        public static List<servicio> Consultar(string id)
        {
            List<servicio> oListarTipoServicio = new List<servicio>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute [PA_consultar_Servicio]'" + id+ "'";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);

            if (objEst.Consultar(sentencia, false))
            {

                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarTipoServicio.Add(new servicio()
                    {
                        idServicio = Convert.ToInt32(dr["idServicio"]),
                        nombreServicio = dr["nombreServicio"].ToString(),
                        precioServicio = dr["precioServicio"].ToString()

                    });

                }
                return oListarTipoServicio;
            }
            else
            {
                return oListarTipoServicio;
            }
        }





    }

}