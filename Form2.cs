using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form2 : Form
    {
       

        public List<Usuario> listaUsuarios = new List<Usuario>();

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonRegistro_Click(object sender, EventArgs e)
        {
            if (contrasenaRegistro.Text.ToString().Equals(confirmarContrasena.Text.ToString())) 
            {
                Usuario user = new Usuario(nombreRegistro.Text.ToString(), correoRegistro.Text.ToString(), contrasenaRegistro.Text.ToString());
                listaUsuarios.Add(user);
            }
        }

        public List<Usuario> getLista()
        {
            return listaUsuarios;
        }
    }
}
