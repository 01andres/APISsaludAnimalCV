using APISsaludAnimalClnicaVeterinatia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace APISsaludAnimalClnicaVeterinatia.Data
{
    public class UsuarioData
    {
        public static Boolean RegistarUsuario(Usuario oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            string fechaFormateada = oUsuario.fechaNacimiento.ToString("yyyy-MM-dd");
            sentencia = "execute PA_insertar_usuario '" + oUsuario.idDocumentoUsuario + "','" + oUsuario.nombreUsuario + "','" + oUsuario.apellido + "','" + oUsuario.contacto + "','" + oUsuario.mail + "','" + oUsuario.contrasenia + "','" + fechaFormateada + "','" + oUsuario.idTipoUsuario + "'";
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

        public static bool actualizarUsuario(Usuario oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            string fechaFormateada = oUsuario.fechaNacimiento.ToString("yyyy-MM-dd");
            sentencia = "execute PA_actualizar_usuario '" + oUsuario.idDocumentoUsuario + "','" + oUsuario.nombreUsuario + "','" + oUsuario.apellido + "','" + oUsuario.contacto + "','" + oUsuario.mail + "','" + oUsuario.contrasenia + "','" + fechaFormateada + "','" + oUsuario.idTipoUsuario + "'";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);
            if (!objEst.EjecutarSentencia(sentencia, false))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            

        }

        public static bool borrarUsuario(Usuario oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "execute PA_borrar_usuario'" + oUsuario.idDocumentoUsuario + "'";
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

        public static List<Usuario> Listar()
        {
            List<Usuario> oListarUsuario = new List<Usuario>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "PA_listar_usuario";

            Console.WriteLine("andres listar " + sentencia);
            if (objEst.Consultar(sentencia,false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarUsuario.Add(new Usuario()
                    {
                        idDocumentoUsuario = Convert.ToInt32(dr["idDocumentoUsuario"]),
                        nombreUsuario = dr["nombreUsuario"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        contacto = dr["contacto"].ToString(), 
                        mail = dr["mail"].ToString(),
                        contrasenia = dr["contrasenia"].ToString(),
                        fechaNacimiento = Convert.ToDateTime( dr["fechaNacimiento"].ToString()),
                        idTipoUsuario = Convert.ToInt32(dr["idTipoUsuario"])

                    });
                }
                return oListarUsuario;

            }
            else 
            {
            return oListarUsuario ;
            }
        }

        public static List<Usuario> Consultar(string id)
        {
            List<Usuario> oUsuario = new List<Usuario>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "[PA_consultar_Usuario]'" + id+ "'";
            System.Diagnostics.Debug.WriteLine("andres insert " + sentencia);

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oUsuario.Add(new Usuario()
                    {
                        idDocumentoUsuario = Convert.ToInt32(dr["idDocumentoUsuario"]),
                        nombreUsuario = dr["nombreUsuario"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        contacto = dr["contacto"].ToString(),
                        mail = dr["mail"].ToString(),
                        contrasenia = dr["contrasenia"].ToString(),
                        fechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"].ToString()),
                        idTipoUsuario = Convert.ToInt32(dr["idTipoUsuario"])

                    });
                }
                return oUsuario;

            }
            else
            {
                return oUsuario;
            }
        }



    }

  }