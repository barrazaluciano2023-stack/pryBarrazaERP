using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaERP
{
    internal class CConexion
    {
        public OleDbConnection conectorBaseDatos;
        public string estadoConexion = "sin conexion";
        public void ConectarBaseDatos()
        {
            try
            {
                conectorBaseDatos = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\DATABASE\Barraza.accdb;Persist Security Info=False;");
                conectorBaseDatos.Open();
                estadoConexion = conectorBaseDatos.State.ToString();



            }
            catch (Exception error)
            {
                estadoConexion = "error: " + error.Message;
                throw;
            }
        }
        public bool login(string usuario, string contrasena)
        {

            try
            {
                ConectarBaseDatos();

                string consulta = "SELECT * FROM Usuario WHERE Nombre = @usuario AND Contrasena = @contrasena";

                OleDbCommand cmd = new OleDbCommand(consulta, conectorBaseDatos);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contrasena);

                OleDbDataReader lector = cmd.ExecuteReader();

                if (lector.Read())//Si existe → devuelve true, si no existe → devuelve false
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                if (conectorBaseDatos != null)
                {
                    conectorBaseDatos.Close();
                }
            }
        }
        public void RegistrarUsuario(
         string nombre,
         string apellido,
         string dni,
         string usuario,
         string contrasena,
         string perfil,
         bool activo)
        {
            try
            {
                ConectarBaseDatos();

                string consulta = @"INSERT INTO Usuario
                (
                    Nombre,
                    Apellido,
                    dni,
                    usuario,
                    Contrasena,
                    Perfil,
                    activo
                )
                VALUES
                (
                    ?,?,?,?,?,?,?
                )";

                OleDbCommand cmd = new OleDbCommand(consulta, conectorBaseDatos);

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@DNI", dni);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                cmd.Parameters.AddWithValue("@Perfil", perfil);
                cmd.Parameters.AddWithValue("@activo", activo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conectorBaseDatos.Close();
            }
        }
        public void registrarContacto(string mail, string telefono, string redSocial, string usuarioRedSocial)
        {
            {
                try
                {
                    ConectarBaseDatos();

                    string consulta = @"INSERT INTO contacto
                        (
                           mail,telefono,redSocial,usuarioRedSocial
                        )
                        VALUES
                        (
                            ?,?,?,?
                        )";

                    OleDbCommand cmd = new OleDbCommand(consulta, conectorBaseDatos);

                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@redSocial", redSocial);
                    cmd.Parameters.AddWithValue("@usuarioRedSocial", usuarioRedSocial);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conectorBaseDatos.Close();
                }
            }
        }
        public void registrarDireccion(string direccion, string provincia, string localidad)
        {
            {
                try
                {
                    ConectarBaseDatos();
                    string consulta = @"INSERT INTO domicilio
                    (
                        direccion,provincia,localidad
                    )
                    VALUES
                        (
                            ?,?,?
                        )";

                    OleDbCommand cmd = new OleDbCommand(consulta, conectorBaseDatos);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@provincia", provincia);
                    cmd.Parameters.AddWithValue("@localidad", localidad);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conectorBaseDatos.Close();
                }
            }
        }
    }
}
