using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
       
        public int RegistrarUsuario(
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

                        cmd.CommandText = "SELECT @@IDENTITY";

                        int idUsuario = Convert.ToInt32(cmd.ExecuteScalar());

                        return idUsuario;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return 0;
                    }
                    finally
                    {
                        if (conectorBaseDatos != null)
                        {
                            conectorBaseDatos.Close();
                        }
                    }
                }
        public void registrarContacto(int idUsuario, string mail, string telefono, string redSocial, string usuarioRedSocial)
        {
            {
                try
                {
                    ConectarBaseDatos();

                    string consulta = @"INSERT INTO contacto
                        (
                           IdUsuario, mail,telefono,redSocial,usuarioRedSocial
                        )
                        VALUES
                        (
                            ?,?,?,?,?
                        )";

                    OleDbCommand cmd = new OleDbCommand(consulta, conectorBaseDatos);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
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
        public void registrarDireccion(int idUsuario, string direccion, string provincia, string localidad)
        {
            {
                try
                {
                    ConectarBaseDatos();
                    string consulta = @"INSERT INTO domicilio
                    (
                       IdUsuario, direccion,provincia,localidad
                    )
                    VALUES
                        (
                           ?,?,?,?
                        )";

                    OleDbCommand cmd = new OleDbCommand(consulta, conectorBaseDatos);

                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
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
        public string ObtenerPerfil(string usuario, string contrasena)
        {
            try
            {
                ConectarBaseDatos();

                string consulta = "SELECT Perfil FROM Usuario WHERE Nombre = ? AND Contrasena = ?";

                OleDbCommand cmd = new OleDbCommand(consulta, conectorBaseDatos);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    return resultado.ToString();
                }

                return "";
            }
            catch
            {
                return "";
            }
            finally
            {
                if (conectorBaseDatos != null)
                {
                    conectorBaseDatos.Close();
                }
            }
        }
        

        public DataTable ListarUsuarios()
        {
            DataTable tabla = new DataTable();

            try
            {
                ConectarBaseDatos();

                string consulta =
                @"SELECT IdUsuario,
                 Nombre & ' ' & Apellido AS NombreCompleto
          FROM Usuario";

                OleDbDataAdapter da =
                    new OleDbDataAdapter(consulta, conectorBaseDatos);

                da.Fill(tabla);
            }
            finally
            {
                conectorBaseDatos.Close();
            }

            return tabla;
        }
        public DataTable ObtenerDatosUsuario(int idUsuario)
        {
            DataTable tabla = new DataTable();

            try
            {
                ConectarBaseDatos();

                string consulta =
                  @"SELECT *
                  FROM (Usuario
                  INNER JOIN contacto
                  ON Usuario.IdUsuario = contacto.IdUsuario)
                  INNER JOIN domicilio
                  ON Usuario.IdUsuario = domicilio.IdUsuario
                  WHERE Usuario.IdUsuario = ?";

                OleDbCommand cmd =
                    new OleDbCommand(consulta, conectorBaseDatos);

                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                OleDbDataAdapter da =
                    new OleDbDataAdapter(cmd);

                da.Fill(tabla);
            }
            finally
            {
                conectorBaseDatos.Close();
            }

            return tabla;
        }

        public void ActualizarUsuario(
        int idUsuario,
        string nombre,
        string apellido,
        string dni,
        string usuario,
        string contrasena,
        string perfil,
        bool activo)
        {
            ConectarBaseDatos();

            string consulta =
                @"UPDATE Usuario
                SET Nombre=?,
                Apellido=?,
                dni=?,
                usuario=?,
                Contrasena=?,
                Perfil=?,
                activo=?
                WHERE IdUsuario=?";

            OleDbCommand cmd =
                new OleDbCommand(consulta, conectorBaseDatos);

            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Apellido", apellido);
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@Contrasena", contrasena);
            cmd.Parameters.AddWithValue("@Perfil", perfil);
            cmd.Parameters.AddWithValue("@activo", activo);
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

            cmd.ExecuteNonQuery();

            conectorBaseDatos.Close();
        }

        public void ActualizarContacto(
            int idUsuario,
            string mail,
            string telefono,
            string redSocial,
            string usuarioRedSocial)
        {
            ConectarBaseDatos();

            string consulta =
            @"UPDATE contacto
            SET mail=?,
            telefono=?,
            redSocial=?,
            usuarioRedSocial=?
            WHERE IdUsuario=?";

            OleDbCommand cmd = new OleDbCommand(consulta, conectorBaseDatos);

            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@redSocial", redSocial);
            cmd.Parameters.AddWithValue("@usuarioRedSocial", usuarioRedSocial);
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

            cmd.ExecuteNonQuery();

            conectorBaseDatos.Close();
        }

        public void ActualizarDireccion(
            int idUsuario,
            string direccion,
            string provincia,
            string localidad)
        {
            ConectarBaseDatos();

            string consulta =
            @"UPDATE domicilio
            SET direccion=?,
             provincia=?,
          localidad=?
            WHERE IdUsuario=?";

            OleDbCommand cmd =  new OleDbCommand(consulta, conectorBaseDatos);

            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            cmd.Parameters.AddWithValue("@localidad", localidad);
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

            cmd.ExecuteNonQuery();

            conectorBaseDatos.Close();
        }

        public DataTable ObtenerLocalidades(string provincia)
        {
            DataTable tabla = new DataTable();

            try
            {
                ConectarBaseDatos();

                string consulta =
                    "SELECT Localidad FROM Localidades WHERE Provincia = ? ORDER BY Localidad";

                OleDbCommand cmd =
                    new OleDbCommand(consulta, conectorBaseDatos);

                cmd.Parameters.AddWithValue("@Provincia", provincia);

                OleDbDataAdapter da =
                    new OleDbDataAdapter(cmd);

                da.Fill(tabla);
            }
            finally
            {
                conectorBaseDatos.Close();
            }

            return tabla;
        }
        public int ObtenerIdUsuarioPorDni(string dni)
        {
            int idUsuario = 0;

            try
            {
                ConectarBaseDatos();

                string consulta =
                    "SELECT IdUsuario FROM Usuario WHERE DNI = ?";

                OleDbCommand cmd =
                    new OleDbCommand(consulta, conectorBaseDatos);

                cmd.Parameters.AddWithValue("@DNI", dni);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    idUsuario = Convert.ToInt32(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conectorBaseDatos.Close();
            }

            return idUsuario;
        }
        public void registrarContactoExtra(int idUsuario, string mail, string telefono, string redSocial)
        {
            {
                try
                {
                    ConectarBaseDatos();

                    string consulta = @"INSERT INTO contacto
                        (
                           IdUsuario, mail,telefono,redSocial
                        )
                        VALUES
                        (
                            ?,?,?,?
                        )";

                    OleDbCommand cmd = new OleDbCommand(consulta, conectorBaseDatos);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@redSocial", redSocial);

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
        public void registrarDireccion2(int idUsuario, string direccion, string provincia, string localidad)
        {
            {
                try
                {
                    ConectarBaseDatos();
                    string consulta = @"INSERT INTO domicilio
                    (
                       IdUsuario, direccion,provincia,localidad
                    )
                    VALUES
                        (
                           ?,?,?,?
                        )";

                    OleDbCommand cmd = new OleDbCommand(consulta, conectorBaseDatos);

                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
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
