using System;
using System.Drawing;
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

        // evento para finaliar la aplicación desde el bótón "salir"
        private void btnLog_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // evento para cambiar al formulario de registro
        private void btnLog_Registrar_Click(object sender, EventArgs e)
        {
            form_Registro abrir = new form_Registro();
            abrir.Show();
            this.Hide();
        }
        // evento para comprobar que el usuario y la contraseseña sean correctas
        private void btnLog_Login_Click(object sender, EventArgs e)
        {
            // variables que leen los valores ingresados en los texbox
            string user = textBoxLog_User.Text;
            string password = textBoxLog_Password.Text;

            // estructura de busqueda (validar inicio de sesión) 

            // almacenamos en la variable "contenido", la lectura del archivo usuarios.txt
            string ruta = Ruta.rutaUsuario;
            StreamReader lectura = File.OpenText(ruta);
            string contenido = lectura.ReadToEnd();
            lectura.Close();

            // separamos cada usuario registrado en un array
            string[] usuarios = contenido.Split('\n');

            // dentro de un ciclo leemos los datos de cada usuario
            for (int x = 0; x < (usuarios.Length - 1); x++)
            {
                // separamos la informacion en usuario y constraseña
                string[] usuario = usuarios[x].Split(',');

                // si los campos estan "vacíos" 
                if (user.Equals("Usuario") && password.Equals("Contraseña"))
                {
                    labelLog_Message.Text = "Los elementos no pueden quedar vacíos";
                    labelLog_Message.Visible = true;
                    userLogLine.ForeColor = Color.Red;
                    passLogLine.ForeColor = Color.Red;

                }// si uno de los campos esta vacío y el otro no 
                else if (!(user.Equals("Usuario")) && password.Equals("Contraseña"))
                {
                    labelLog_Message.Text = "Los elementos no pueden quedar vacíos";
                    labelLog_Message.Visible = true;
                    passLogLine.ForeColor = Color.Red;

                }else if (user.Equals("Usuario") && !(password.Equals("Contraseña")))
                {
                    labelLog_Message.Text = "Los elementos no pueden quedar vacíos";
                    labelLog_Message.Visible = true;
                    userLogLine.ForeColor = Color.Red;
                } // si los campos no estan vacío y se encuentran en usuarios.txt
                else  if (usuario[0].Trim().Equals(user.ToLower()) && usuario[1].Trim().Equals(password))
                {
                    form_Menu abrir = new form_Menu();
                    abrir.Show();
                    abrir.textBoxMenu_userlog.Text = user.ToLower();
                    this.Hide();

                }  // si solo uno de los campos ingresados se encuentran en usuarios.txt
                else if (!(usuario[0].Trim().Equals(user.ToLower())) && usuario[1].Trim().Equals(password))
                {
                    labelLog_Message.Text = "   Favor de verificar datos ingresados";
                    labelLog_Message.Visible = true;
                    userLogLine.ForeColor = Color.Red;
                    passLogLine.ForeColor = Color.Red;
                }
                else if ( usuario[0].Trim().Equals(user.ToLower()) && !(usuario[1].Trim().Equals(password)))
                {
                    labelLog_Message.Text = "               Contraseña incorrecta";
                    labelLog_Message.Visible = true;
                    passLogLine.ForeColor = Color.Red;

                }// si ninguno de los campos ingresados se encuentran en usuarios.txt 
                else if (!(usuario[0].Trim().Equals(user.ToLower())) && !(usuario[1].Trim().Equals(password)))
                {
                    labelLog_Message.Text = "   Favor de verificar datos ingresados";
                    labelLog_Message.Visible = true;
                    userLogLine.ForeColor = Color.Red;
                    passLogLine.ForeColor = Color.Red;
                }


            }
        }
        // evento para finaliar la aplicación desde el bótón superior derecho
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        // eventos que crean el efecto placeholder 
        private void textBoxLog_User_Enter(object sender, EventArgs e)
        {   // si el texbox no esta vacío al hacer Enter, se vacía 
            if (textBoxLog_User.Text == "Usuario")
            {
                textBoxLog_User.Text = "";
            }
            textBoxLog_User.ForeColor = Color.White;
            userLogLine.ForeColor = Color.White;
        }

        private void textBoxLog_User_Leave(object sender, EventArgs e)
        {       // si el texbox esta vacio al salir de el, este se llenara con el texto placeholder
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
            passLogLine.ForeColor = Color.White;
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
                Ruta.noRuta = "Ruta del documento usuarios.txt y estacion.txt no encontrada" +
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
                    Ruta.noRuta = "Ruta del documento usuarios.txt no encontrada" +
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
                        Ruta.noRuta = "Ruta  del documento estacion.txt no encontrada" +
                            ", favor de comprobar su exitenicia y/o cambiar la direccion dentro de program.cs" +
                            " en la variable: rutaEstacion... De click en ACEPTAR para salir del programa";
                        mensaje.textBoxAlert_Message.Text = Ruta.noRuta;
                        Opacity = .85;
                        Enabled = false;
                    }
                }
            }          
        }
        //Eventos que personalizan el botón Salir 
        private void btnLog_Salir_MouseHover(object sender, EventArgs e)
        {
            //cambia de color si estamos sobre él
            btnLog_Salir.ForeColor = Color.Red;
        }

        private void btnLog_Salir_MouseLeave(object sender, EventArgs e)
        {
            //se vuelve al color original se nos vamos
            btnLog_Salir.ForeColor = Color.White;
        }

        //Evento que despliega un mensaje de alerta para indicar al usuario que la funcionalidad aún no esta desarrollada
        private void linkLabelLog_RecuperarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ocurre cuando se intenta acceder  la funcionalidad contraseña
            MensajeAlerta mensaje = new MensajeAlerta();
            mensaje.Show();
            mensaje.textBoxAlert_Message.Text = "Opción no disponible";
            mensaje.textBoxAlert_Message.Location = new Point(34, 93);
            
        }
    }
}
