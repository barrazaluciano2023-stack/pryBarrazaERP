using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaERP
{
    internal class clsAuditoria
    {
        CConexion conexion = new CConexion();

        public  void GrabarDatos(string usuario,string contrasena, string fechaYHora,string intentos)
        {
            conexion.ConectarBaseDatos();

            string perfilQuery = "SELECT perfil FROM Usuario WHERE Nombre = @usuario AND Contrasena = @contrasena";

            OleDbCommand cmd = new OleDbCommand(perfilQuery, conexion.conectorBaseDatos);

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contrasena);

            OleDbDataReader lector = cmd.ExecuteReader();

            if (lector.Read())
            {
                string perfil = lector["perfil"].ToString();
                string query = "INSERT INTO [Auditoria-Sesion] (fechaHora, perfil,intentos,usuario) VALUES (?,?,?,?)";
                using (OleDbCommand cmd2 = new OleDbCommand(query, conexion.conectorBaseDatos))
                    try
                    {
                        cmd2.Parameters.AddWithValue("@fechaHora",fechaYHora);
                        cmd2.Parameters.AddWithValue("perfil", perfil);
                        cmd2.Parameters.AddWithValue("intentos", intentos);
                        cmd2.Parameters.AddWithValue("usuario", usuario);
                        cmd2.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ejecutar comando: " + ex.Message);
                    }
            }
            
        }

        public void CargarIngresos(DataGridView ingresoos)
        {
            conexion.ConectarBaseDatos();
            string ingresos = "SELECT * FROM [Auditoria-Sesion]";
            OleDbDataAdapter cmd = new OleDbDataAdapter(ingresos, conexion.conectorBaseDatos);
            

            DataTable dt = new DataTable();

            cmd.Fill(dt);

            ingresoos.DataSource = dt;
        }
    }
            
    
}
