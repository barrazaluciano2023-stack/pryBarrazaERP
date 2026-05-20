using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
        public bool login(string usuario,string contrasena)
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
    }
}
