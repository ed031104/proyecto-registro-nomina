using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.IO.Pipes;
using MaterialSkin;
using System.Threading;
using poyectoExamen2.Logica;
using System.Collections;
using System.IO;

namespace poyectoExamen2
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        Thread hilo1;
        List<Persona> listaPersona = new List<Persona>();

        public Form1()
        {
            InitializeComponent();

            hilo1 = new Thread(llenarLista);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
            Accent.Blue400, TextShade.WHITE);

            hilo1.Start();
        }



        private void SalirBtn_Click(object sender, EventArgs e) {
             Application.Exit();
        }

        private void GuardarEmpleadoBtn_Click_1(object sender, EventArgs e)
        {
            
            String nombre = nombreUsuarioTxt.Text;
            String apellido = apellidoUsuarioTxt.Text;
            String direccion = direccionUsuarioTxt.Text;

            Persona persona = new Persona(nombre, apellido, direccion);

            notificacion("Binvenido " + persona.getNombre() + " has sido agregado", "Resources/verificado.ico");
            //MessageBox.Show("Binvenido "+persona.getNombre()+" has sido agregado");

            listaPersona.Add(persona);
            llenarLista();
        }
        
        private void BuscarUsuarioBtn_Click(object sender, EventArgs e)
        {

        }

        public void llenarLista()
        {
            try
            {
                if (listaPersona != null && listaPersona.Count > 0)
                {
                    lista.Controls.Clear();
                    foreach (Persona persona in listaPersona)
                    {
                        BeginInvoke((MethodInvoker)delegate ()
                        {
                            ListaUsuario nuevoUsuario = new ListaUsuario();
                            nuevoUsuario.nombre = persona.getNombre();
                            nuevoUsuario.BackColor = Color.Blue;
                            lista.Controls.Add(nuevoUsuario);
                        });

                        Thread.Sleep(100); // Mover dentro del bucle para un retraso entre elementos
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void notificacion(String mensaje, String ruta) {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../"+ruta));
            notifyIcon1.Text = "sistema de registro";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Notificacion de sistema de registro";
            notifyIcon1.BalloonTipText = mensaje;
            notifyIcon1.ShowBalloonTip(5);
        }
    }
}
