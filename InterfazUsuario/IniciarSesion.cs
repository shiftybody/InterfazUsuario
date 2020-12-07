using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace InterfazUsuario
{
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();
            // agrego la imagen del pictureBox como objeto de una imagen 
            // sobrepuesta, que requiere tener transparencia
            pictureBoxlog_Fondo.Controls.Add(pictureBoxLog_Imagen);
            pictureBoxLog_Imagen.Location = new Point(135,200);
            this.pictureBoxLog_Imagen.BackColor = Color.Transparent;
        }


        private void btnLog_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLog_Registrar_Click(object sender, EventArgs e)
        {
            form_Registro abrir = new form_Registro();
            abrir.Show();
            this.Hide();
        }

        private void btnLog_Login_Click(object sender, EventArgs e)
        {
            string user, password;

            user = textBoxLog_User.Text;
            password = textBoxLog_Password.Text;

            if (user.Equals("admin") && password.Equals("1234"))
            {
                form_Menu abrir = new form_Menu();
                abrir.Show();
                this.Hide();
            }
            else
            {
                labelLog_Message.Visible = true;
                label_Usuario.ForeColor = Color.FromArgb(176, 0, 32);
                label_Contraseña.ForeColor = Color.FromArgb(176, 0, 32);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxLog_User_Enter(object sender, EventArgs e)
        {
            if(textBoxLog_User.Text == "Usuario")
            {
                textBoxLog_User.Text = "";
            }
            textBoxLog_User.ForeColor = Color.White;
        }

        private void textBoxLog_User_Leave(object sender, EventArgs e)
        {
            if (textBoxLog_User.Text == "")
            {
                textBoxLog_User.Text = "Usuario";
                textBoxLog_User.ForeColor = Color.Gray;
            } 
        }

        private void textBoxLog_Password_Enter(object sender, EventArgs e)
        {
            if (textBoxLog_Password.Text == "Contraseña")
            {
                textBoxLog_Password.Text = "";
                textBoxLog_Password.UseSystemPasswordChar = true ;
            }
            textBoxLog_Password.ForeColor = Color.White;
        }

        private void textBoxLog_Password_Leave(object sender, EventArgs e)
        {
            if (textBoxLog_Password.Text == "")
            {
                textBoxLog_Password.UseSystemPasswordChar = false;
                textBoxLog_Password.Text = "Contraseña";
                textBoxLog_Password.ForeColor = Color.Gray;
            }
        }

        // codigo que se ejecuta cuando el formulario aparece por primera vez
        // verificando si las variables a los path de nuestros archivos son correctas
         private void form_Login_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(Ruta.rutaUsuario) && !File.Exists(Ruta.rutaEstacion))
            {
                //se instancia un objeto de la clase MensajeAlerta
                //pasando los parametros del mensaje para el texbox del formulario "MensajeAlerta"
                MensajeAlerta mensaje = new MensajeAlerta();
                mensaje.Show();
                //el mensaje se guarda en una variable publica por si es necesario utilizarla desde otro formulario
                Ruta.noRuta = "Ruta raiz del documento usuarios.txt y estacion.txt no encontrada" +
                    ", favor de comprobar su exitenicia y/o cambiar la direccion dentro de program.cs" +
                    " en las variable: rutaUsuario y rutaEstacion. De click en ACEPTAR para salir del programa";
                mensaje.textBoxAlert_Message.Text = Ruta.noRuta;
                Opacity = .85;
                Enabled = false;
            }
            else
            {
                if (!File.Exists(Ruta.rutaUsuario))
                {
                   //El mensaje cambia segun los archivos detectados 
                    MensajeAlerta mensaje = new MensajeAlerta();
                    mensaje.Show();
                    Ruta.noRuta = "Ruta raiz del documento usuarios.txt no encontrada" +
                        ", favor de comprobar su exitenicia y/o cambiar la direccion dentro de program.cs" +
                        " en la variable: rutaUsuario... De click en ACEPTAR para salir del programa";
                    mensaje.textBoxAlert_Message.Text = Ruta.noRuta;
                    Opacity = .85;
                    Enabled = false;

                }
                else
                {
                    if (!File.Exists(Ruta.rutaEstacion))
                    {
                        MensajeAlerta mensaje = new MensajeAlerta();
                        mensaje.Show();
                        Ruta.noRuta = "Ruta raiz del documento estacion.txt no encontrada" +
                            ", favor de comprobar su exitenicia y/o cambiar la direccion dentro de program.cs" +
                            " en la variable: rutaEstacion... De click en ACEPTAR para salir del programa";
                        mensaje.textBoxAlert_Message.Text = Ruta.noRuta;
                        Opacity = .85;
                        Enabled = false;
                    }
                }
            }          
        }

        private void btnLog_Salir_MouseHover(object sender, EventArgs e)
        {
            btnLog_Salir.ForeColor = Color.Red;
        }

        private void btnLog_Salir_MouseLeave(object sender, EventArgs e)
        {
            btnLog_Salir.ForeColor = Color.White;
        }

        private void linkLabelLog_RecuperarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             
            MensajeAlerta mensaje = new MensajeAlerta();
            mensaje.Show();
            mensaje.textBoxAlert_Message.Text = "Opción no disponible";
            mensaje.textBoxAlert_Message.Location = new Point(34, 93);
            
        }
    }
}
