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

        public void GrabarMovimiento(
            string usuario,
            string formulario,
            string accion)
        {
            try
            {
                conexion.ConectarBaseDatos();

                string consulta =
                @"INSERT INTO AuditoriaMovimientos
                (
                    Usuario,
                    FechaHora,
                    Formulario,
                    Accion
                )
                VALUES
                (
                    ?,?,?,?
                )";

                OleDbCommand cmd =
                    new OleDbCommand(
                        consulta,
                        conexion.conectorBaseDatos);

                cmd.Parameters.AddWithValue(
                    "@Usuario",
                    usuario);

                cmd.Parameters.AddWithValue(
                    "@FechaHora",
                    DateTime.Now);

                cmd.Parameters.AddWithValue(
                    "@Formulario",
                    formulario);

                cmd.Parameters.AddWithValue(
                    "@Accion",
                    accion);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.conectorBaseDatos.Close();
            }
        }

        public void CargarMovimientos(DataGridView dgv)
        {
            conexion.ConectarBaseDatos();

            string consulta =
                "SELECT * FROM AuditoriaMovimientos";

            OleDbDataAdapter da =
                new OleDbDataAdapter(
                    consulta,
                    conexion.conectorBaseDatos);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            dgv.DataSource = dt;

            conexion.conectorBaseDatos.Close();
        }
        public DataTable ObtenerIngresos()
        {
            DataTable dt = new DataTable();

            conexion.ConectarBaseDatos();

            string consulta =
                "SELECT * FROM [Auditoria-Sesion]";

            OleDbDataAdapter da =
                new OleDbDataAdapter(
                    consulta,
                    conexion.conectorBaseDatos);

            da.Fill(dt);

            conexion.conectorBaseDatos.Close();

            return dt;
        }
        public DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();

            try
            {
                conexion.ConectarBaseDatos();

                string consulta =
                    "SELECT DISTINCT usuario FROM [Auditoria-Sesion]";

                OleDbDataAdapter da =
                    new OleDbDataAdapter(
                        consulta,
                        conexion.conectorBaseDatos);

                da.Fill(dt);
            }
            finally
            {
                conexion.conectorBaseDatos.Close();
            }

            return dt;
        }
        public DataTable ObtenerMovimientos()
        {
            DataTable dt = new DataTable();

            conexion.ConectarBaseDatos();

            string consulta =
                "SELECT * FROM AuditoriaMovimientos";

            OleDbDataAdapter da =
                new OleDbDataAdapter(
                    consulta,
                    conexion.conectorBaseDatos);

            da.Fill(dt);

            conexion.conectorBaseDatos.Close();

            return dt;
        }
    }


}
