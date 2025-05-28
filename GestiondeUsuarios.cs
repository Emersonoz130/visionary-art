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
    public partial class GestiondeUsuarios : UserControl
    {
        public GestiondeUsuarios()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (cbxRoles.SelectedItem==null) {
               // MessageBox.Show("Selecciona uno por favor");
                MessageBox.Show("Selecciona un rol por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                MessageBox.Show("Se creo un nuevo usuario","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //MessageBox.Show("Se selecciono");
            }
        }
    }
}
