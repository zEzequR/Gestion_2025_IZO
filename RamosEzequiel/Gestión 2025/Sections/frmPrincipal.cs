using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_2025
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Conexion connect = new Conexion();
            connect.Connect();
        }

        private void ProvBtn_Click(object sender, EventArgs e)
        {
            frmRznSocial frmRznSocial = new frmRznSocial();
            frmRznSocial.ShowDialog();
        }

        private void ItemsBtn_Click(object sender, EventArgs e)
        {
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
        }
    }
}
