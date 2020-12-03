using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();

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
    }
}
