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
            this.textBoxLog_User.AutoSize = false;
            this.textBoxLog_User.Size = new System.Drawing.Size(224, 30);
            this.textBoxLog_Password.AutoSize = false;
            this.textBoxLog_Password.Size = new System.Drawing.Size(224, 30);
        }

        private void textBox_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e) // es el label de la pregunta de contraseña solo que le di click antes de cambiar el nombre
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

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

        private void labelLog_Message_Click(object sender, EventArgs e)
        {

        }
    }
}
