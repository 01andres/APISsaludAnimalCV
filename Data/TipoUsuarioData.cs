using APISsaludAnimalClnicaVeterinatia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APISsaludAnimalClnicaVeterinatia.Data
{
    public class TipoUsuarioData
    {
        public static bool registrarTipoUsuario(Tipo_usuario otipoUsuario)
        {
            ConexionBD objEst=new ConexionBD();
            string sentencia;
            sentencia = "execute PA_insertar_tipoUsuario'" + otipoUsuario.idTipoUsuario + "','" + otipoUsuario.nombreTipoUsuario + "'";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);


            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false; 
            }
            else
            {
                objEst = null ;
                return true;
            }


        }

        public static bool actualizarTipoUsuario(Tipo_usuario otipoUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_actualizar_tipoUsuario'" + otipoUsuario.idTipoUsuario + "','" + otipoUsuario.nombreTipoUsuario + "'";
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



        public static bool borrarTipoUsuario(Tipo_usuario otipoUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_borrar_tipoUsuario'" + otipoUsuario.idTipoUsuario + "'";
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

        public static List<Tipo_usuario> Listar()
        {
            List<Tipo_usuario> oListarTipoUsuario = new List<Tipo_usuario>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_listar_tipoUsuario";
            System.Diagnostics.Debug.WriteLine("Andres insert " + sentencia);

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarTipoUsuario.Add(new Tipo_usuario()
                    {
                        idTipoUsuario = Convert.ToInt32(dr["idTipoUsuario"]),
                        nombreTipoUsuario = dr["nombreTipoUsuario"].ToString()

                    });

                }
                return oListarTipoUsuario;
            }
            else
            {
                return oListarTipoUsuario;
            }

        }

        public static List<Tipo_usuario> Consultar(string id)
        {
            List<Tipo_usuario> oListarTipoUsuario = new List<Tipo_usuario>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute [PA_consultar_tipoUsuario]'" + id + "'";
            System.Diagnostics.Debug.WriteLine("Andres insert " + sentencia);

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarTipoUsuario.Add(new Tipo_usuario()
                    {
                        idTipoUsuario = Convert.ToInt32(dr["idTipoUsuario"]),
                        nombreTipoUsuario = dr["nombreTipoUsuario"].ToString()

                    });

                }
                return oListarTipoUsuario;
            }
            else
            {
                return oListarTipoUsuario;
            }

        }




    }

}