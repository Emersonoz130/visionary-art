using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visionary_Arts_Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGestionUsuario_Click(object sender, EventArgs e)
        {
            GestiondeUsuarios gestionUsuarios = new GestiondeUsuarios();
            panel2.Controls.Clear();
            panel2.Controls.Add(gestionUsuarios);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionRoles_Click(object sender, EventArgs e)
        {
            GestiondeRoles gestionRoles = new GestiondeRoles();
            panel2.Controls.Clear();
            panel2.Controls.Add(gestionRoles);
        }
    }
}
