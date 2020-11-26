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
    public partial class form_Registro : Form
    {
        public form_Registro()
        {
            InitializeComponent();
        }

        private void label_ContraseñaConfirmada_Click(object sender, EventArgs e)
        {

        }

        private void btn_regresarLogin_Click(object sender, EventArgs e)
        {
            form_Login abrir = new form_Login();
            abrir.Show();
            this.Hide();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            string usuario = null;
            string password = null;
            string passwordValidation = null;

            usuario = textBox_UserRegister.Text;
            password = textBox_PasswordRegister.Text;
            passwordValidation = textBox_PasswordConfirm.Text;

            string ruta = @"C:\Users\david\Documents\IntProg\InterfazUsuario\DB\usuarios.txt";
            StreamWriter escritura = File.AppendText(ruta);


            //Validar que la contraseña sea la misma

            if (password.Equals(passwordValidation) )
            {
                escritura.WriteLine(usuario);
                escritura.WriteLine(password);
                labelResgistro_Message.Text = "Registro exitoso";
                labelResgistro_Message.Visible = true;
                escritura.Close();
                btn_Registrar.Enabled = false;
            }
            else
            {
                labelResgistro_Message.Text = "Contraseña incorrecta";
                labelResgistro_Message.Visible = true;
                escritura.Close();
            }

            //No poder insertar valores en blanco

            //limpiar campos de texto

            //Desabilitar campo de texto

        }

        private void textBox_UserRegister_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox_UserRegister_Leave(object sender, EventArgs e)
        {
            if (textBox_UserRegister.Text != "" && textBox_PasswordRegister.Text != "")
            {
                btn_Registrar.Enabled = true;
            }
        }

        private void textBox_PasswordRegister_Leave(object sender, EventArgs e)
        {
            if (textBox_UserRegister.Text != "" && textBox_PasswordRegister.Text != "")
            {
                btn_Registrar.Enabled = true;
            }
        }
    }
}
