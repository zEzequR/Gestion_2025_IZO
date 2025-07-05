using Gestión_2025.Classes;
using Gestión_2025.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_2025
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //for (int i = 0; i < tableUsers.Columns[2].Index; i++)
            //{
            //    System.Diagnostics.Debug.WriteLine(tableUsers.Rows[i].Cells[2].Value.ToString());
            //    System.Diagnostics.Debug.WriteLine(tableUsers.Rows[i].Cells[1].Value.ToString());
            //}
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.usuario = userInp.Text;
            if (int.TryParse(passwrdInp.Text, out int password))
            {
                user.psw = password;
            }
            else
            {
                userInp.Clear();
                passwrdInp.Clear();
            }


            var userInputs = (userInp.Text, password);
            List<(string, int)> users = new List<(string, int)>();

            Procedures procedure = new Procedures();
            bool? status = procedure.logincomparision(tableUsers, userInputs, users);

            if (status == true)
            {
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Procedures procedure = new Procedures();
            procedure.MostrarDatos("spu_mostrar_users", tableUsers, new List<string> { "ID", "Usuario", "Contraseña" });
        }


        //public void entrar()
        //{
        //    var userInputs = (userInp.Text, Convert.ToInt32(passwrdInp.Text));
        //    List<(string, int)> users = new List<(string, int)>();
        //    for (int i = 0; i < tableUsers.Columns[2].Index; i++)
        //    {
        //        users.Add((tableUsers.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(tableUsers.Rows[i].Cells[2].Value)));
        //    }
        //    if (users.Contains(userInputs))
        //    {
        //        System.Diagnostics.Debug.WriteLine("Usuario encontrado: " + userInputs.Item1 + userInputs.Item2);
        //    }
        //    else
        //    {
        //        System.Diagnostics.Debug.WriteLine("Usuario no encontrado: " + userInputs.Item1 + userInputs.Item2);
        //    }
        //}




        //public void MostrarUsers()
        //    {
        //        List<string> users = new List<string>();
        //        users.Add("ID");
        //        users.Add("Usuario");
        //        users.Add("Contrseña");
        //        Conexion conexion = new Conexion();
        //        var da = new SqlDataAdapter("EXEC spu_mostrar_users", conexion.Connect());
        //        var dt = new DataTable();
        //        da.Fill(dt);
        //        System.Diagnostics.Debug.WriteLine(dt);
        //        tableUsers.DataSource = dt;

        //        foreach (DataGridViewColumn column in tableUsers.Columns)
        //        {
        //            tableUsers.Columns[column.Index].HeaderText = users[column.Index];
        //        }
        //    }
    }
}
