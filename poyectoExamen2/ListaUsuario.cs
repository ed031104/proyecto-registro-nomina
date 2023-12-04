using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poyectoExamen2
{
    public partial class ListaUsuario : UserControl
    {
        public ListaUsuario()
        {
            InitializeComponent();
        }

        #region propiedades

        private String Nombre, cargo, identificación, telefono, cumpleaños, email;
        private Image image;

        [Category("Custom Props")]
        public String nombre { 
            get { return this.Nombre; }
            set { this.Nombre = value; nombres.Text = value; }
        }

        [Category("Custom Props")]
        public String Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; cargoLaboral.Text = value; }
        }


        [Category("Custom Props")]
        public String Identificacion
        {
            get { return this.identificación; }
            set { this.identificación = value; numeroCedula.Text = value; }
        }

        [Category("Custom Props")]
        public String Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; numeroTelefono.Text = value; }
        }

        [Category("Custom Props")]
        public String Cumpleaños
        {
            get { return this.cumpleaños; }
            set { this.cumpleaños = value; fechaCumpleaños.Text = value; }
        }

        [Category("Custom Props")]
        public String Email
        {
            get { return this.email; }
            set { this.email = value; correo.Text = value; }
        }

        [Category("Custom Props")]
        public Image imagen
        {
            get { return this.image; }
            set { this.image = value; FotoPerfil.Image = value; }
        }
        #endregion

        private void ListaUsuario_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.AliceBlue;
        }

        private void ListaUsuario_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
