using APISsaludAnimalClnicaVeterinatia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APISsaludAnimalClnicaVeterinatia.Data
{
    public class CitaData
    {
        public static bool registrarCita(Cita oCita)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_insertar_cita'" +oCita.idDocumentoUsuario+ "'";
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

        public static bool actualizarCita(Cita oCita)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_actualizar_cita'" + oCita.nroCita + "','" + oCita.idDocumentoUsuario + "'";
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

        public static bool borrarrCita(Cita oCita)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_borrar_cita'" + oCita.nroCita + "'" ;
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

        public static List<Cita> Listar()
        {
            List<Cita> oCita = new List<Cita>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_listar_citas";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oCita.Add(new Cita()
                    {
                        nroCita = Convert.ToInt32(dr["nroCita"]),
                        idDocumentoUsuario = Convert.ToInt32(dr["idDocumentoUsuario"]),
                    });

                }
                return oCita;
            }
            else
            {
                return oCita;
            }

        }


        public static List<Cita> Consultar( string  id)
        {
            List<Cita> oCita = new List<Cita>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_consultar_cita'" + id+"'";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oCita.Add(new Cita()
                    {
                        nroCita = Convert.ToInt32(dr["nroCita"]),
                        idDocumentoUsuario = Convert.ToInt32(dr["idDocumentoUsuario"]),
                    });

                }
                return oCita;
            }
            else
            {
                return oCita;
            }

        }

    }
}