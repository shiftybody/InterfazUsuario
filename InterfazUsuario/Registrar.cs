using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class form_Registro : Form
    {
        public form_Registro()
        {
            InitializeComponent();
            // Agrego la imagen del pictureBox como objeto de control del botón "volver".
            pictureBoxRegistrar.Controls.Add(btnRegistrar_volver);
        }

        private void label_ContraseñaConfirmada_Click(object sender, EventArgs e)
        {

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            string user = null;
            string password = null;
            string passwordValidation = null;

            user = textBox_UserRegister.Text;
            password = textBox_PasswordRegister.Text;
            passwordValidation = textBox_PasswordConfirm.Text;

            string ruta = @"C:\Users\david\Documents\IntProg\InterfazUsuario\DB\usuarios.txt";
            StreamWriter escritura = File.AppendText(ruta);

            //escritura.WriteLine(usuario);
            //escritura.WriteLine(password);


            //Validar que la contraseña sea la misma




            //No poder insertar valores en blanco


            //limpiar campos de texto


        }

        // Evento para finalizar la aplicación
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        // Eventos para regresar al formulario login
        private void btn_regresarLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_Login abrir = new form_Login();
            abrir.Show();
            this.Hide();
        }

        private void btnRegistrar_volver_Click(object sender, EventArgs e)
        {
            form_Login abrir = new form_Login();
            abrir.Show();
            this.Hide();
        }
        // Evento para crear efecto placeholder en los textbox del formulario
        private void textBox_UserRegister_Enter(object sender, EventArgs e)
        {           
            // Si mi texbox no esta vacio, al hacer click se vaciara
            if (textBox_UserRegister.Text == "Ingrese un nombre de usuario")
            {
                textBox_UserRegister.Text = "";
            }
            textBox_UserRegister.ForeColor = Color.White;
        }
        private void textBox_UserRegister_Leave(object sender, EventArgs e)
        {           
            // Si el texbox se queda vacío, se agrega el placeholder
            if (textBox_UserRegister.Text == "")
            {
                textBox_UserRegister.Text = "Ingrese un nombre de usuario";
                textBox_UserRegister.ForeColor = Color.Gray;
            }
        }

        private void textBox_PasswordRegister_Enter(object sender, EventArgs e)
        {
            if (textBox_PasswordRegister.Text == "Ingrese una contraseña")
            {
                textBox_PasswordRegister.Text = "";
            }
            textBox_PasswordRegister.ForeColor = Color.White;
        }
        private void textBox_PasswordRegister_Leave(object sender, EventArgs e)
        {
            if (textBox_PasswordRegister.Text == "")
            {
                textBox_PasswordRegister.Text = "Ingrese una contraseña";
                textBox_PasswordRegister.ForeColor = Color.Gray;
            }
        }
        private void textBox_PasswordConfirm_Enter(object sender, EventArgs e)
        {
            if (textBox_PasswordConfirm.Text == "Vuelva a ingresar la contraseña")
            {
                textBox_PasswordConfirm.Text = "";
            }
            textBox_PasswordConfirm.ForeColor = Color.White;
        }
        private void textBox_PasswordConfirm_Leave(object sender, EventArgs e)
        {
            if (textBox_PasswordConfirm.Text == "")
            {
                textBox_PasswordConfirm.Text = "Vuelva a ingresar la contraseña";
                textBox_PasswordConfirm.ForeColor = Color.Gray;
            }
        }

    }
}
