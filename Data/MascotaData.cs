using APISsaludAnimalClnicaVeterinatia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APISsaludAnimalClnicaVeterinatia.Data
{
    public class MascotaData
    {
        public static bool registrarMascota(Mascota oMascota)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_insertar_mascota '"+ oMascota.idNombreMascota + "','" + oMascota.especie+ "'";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);

            if (!objEst.EjecutarSentencia(sentencia,false)) 
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


        public static bool actualizarMascota(Mascota oMascota)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_actualizar_mascota '" + oMascota.idNombreMascota + "','" + oMascota.especie + "'";
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

        public static bool borrarMascota(Mascota oMascota)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_borrar_mascota '" + oMascota.idNombreMascota + "'";
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
        
        public static List<Mascota>listar()
        {
            List<Mascota>oListarMascota = new List<Mascota>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = " execute PA_listar_mascota";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);

            if (objEst.Consultar(sentencia,false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read()) 
                {
                    oListarMascota.Add(new Mascota() 
                    {
                        idNombreMascota = dr["idNombreMascota"].ToString(),
                        especie = dr["especie"].ToString()

                    });

                }
                return oListarMascota;
            }
            else 
            {
            return oListarMascota;
            }
        }

        public static List<Mascota> Consultar(string id)
        {
            List<Mascota> oListarMascota = new List<Mascota>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = " execute PA_consultar_Mascota'"+ id+"'";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarMascota.Add(new Mascota()
                    {
                        idNombreMascota = dr["idNombreMascota"].ToString(),
                        especie = dr["especie"].ToString()

                    });

                }
                return oListarMascota;
            }
            else
            {
                return oListarMascota;
            }
        }
    }

}

