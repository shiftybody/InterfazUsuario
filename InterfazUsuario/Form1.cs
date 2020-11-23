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
            this.textBox_User.AutoSize = false;
            this.textBox_User.Size = new System.Drawing.Size(224, 30);
            this.textBox_Password.AutoSize = false;
            this.textBox_Password.Size = new System.Drawing.Size(224, 30);
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
    }
}
