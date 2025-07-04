using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_2025.Utilities
{
    internal class Procedures
    {
        public void MostrarDatos(string procedureName, DataGridView tableName, List<String> TitleLists)
        {
            var da = new SqlDataAdapter(procedureName, new Conexion().Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            var dt = new DataTable();
            da.Fill(dt);
            tableName.DataSource = dt;
            foreach (DataGridViewColumn column in tableName.Columns)
            {
                tableName.Columns[column.Index].HeaderText = TitleLists[column.Index];
            }
        }

        public void AgregarDatos(string procedureName, List<string> sqlParameters, List<Object> parametros)
        {
            SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < sqlParameters.Count; i++)
            {
                cmd.Parameters.AddWithValue(sqlParameters[i], parametros[i]);
            }
            cmd.ExecuteNonQuery();
        }

        public void EliminarDatos(string procedureName, List<string> sqlParameters, List<Object> parametros)
        {
            SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < sqlParameters.Count; i++)
            {
                cmd.Parameters.AddWithValue(sqlParameters[i], parametros[i]);
            }
            cmd.ExecuteNonQuery();
        }

        public void ActualizarDatos(string procedureName, List<string> sqlParameters, List<Object> parametros)
        {
            SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < sqlParameters.Count; i++)
            {
                cmd.Parameters.AddWithValue(sqlParameters[i], parametros[i]);
            }
            cmd.ExecuteNonQuery();
        }

        public bool? logincomparision(DataGridView tableusers, (string, int) userInputs, List<(string, int)> users)
        {
            for (int i = 0; i < tableusers.Columns[2].Index; i++)
            {
                users.Add((tableusers.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(tableusers.Rows[i].Cells[2].Value)));
            }

            if (users.Contains(userInputs))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
