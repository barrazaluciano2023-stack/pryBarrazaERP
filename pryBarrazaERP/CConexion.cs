using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace pryBarrazaERP
{
    internal class CConexion
    {
        public OleDbConnection conectorBaseDatos;
        public string estadoConexion = "sin conexion";
        //metodos para abrir la base
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
    }
}
