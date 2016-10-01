using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace Registro1
{
    public partial class Registro1 : Form
    {
        public Registro1()
        {
            InitializeComponent();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();

            user.nombre = textBox_Nombre.Text;
            user.apellido = textBox_Apellido.Text;
            user.direccion = textBox_Direccion.Text;
            user.telefono = textBox_Fecha.Text;
            user.edad = Convert.ToInt32(textBox_Fecha.Text);

            if(UsuariosBll.Insertar(user))
            {
                MessageBox.Show("Guardado !!!");
            }
        }
    }
}
