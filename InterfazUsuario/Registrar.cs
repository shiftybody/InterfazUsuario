using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
         
            string user = textBox_UserRegister.Text.ToLower();
            string password = textBox_PasswordRegister.Text;
            string passVald = textBox_PasswordConfirm.Text;
            string ruta = Ruta.rutaUsuario;
            bool existe = false;

            
            // estructura de busqueda (usuario existente)

            // almacenamos en la variable contenido la lectura del archivo usuarios.txt
            StreamReader lectura = File.OpenText(ruta);
            string contenido = lectura.ReadToEnd();
            lectura.Close();

            // separamos cada usuario registrado en un array
            string[] usuarios = contenido.Split('\n');

            // dentro de un ciclo leemos los datos de cada usuario
            for(int x = 0; x < (usuarios.Length - 1); x++)
            {
                // separamos la informacion en usuario y constraseña
                string[] usuario = usuarios[x].Split(',');

                // si el usuario existe, la variable existe sera igual a true
                if (usuario[0].Trim().Equals(user.Trim()))
                {
                    existe = true;
                    break;

                }//si el usuario no existe, la variable existe sera igual a false
                else
                {
                    existe = false;
                }
            }

            //Validar que no queden espacios sin llenar, mostrandoselo a usuario 

            //(caso  x, x ,x)
            if (user.Equals("Ingrese un nombre de usuario") && password.Equals("Ingrese una contraseña") && passVald.Equals("Vuelva a ingresar la contraseña"))
            {
                labelResgistro_Message.Text = "Los elementos no pueden quedar vacíos";
                labelResgistro_Message.Visible = true;
                userLine.ForeColor = Color.Red;
                passwordLine.ForeColor = Color.Red;
                passvalidLine.ForeColor = Color.Red;

            } //(caso  x, - ,-)
            else if (user.Equals("Ingrese un nombre de usuario") && !(password.Equals("Ingrese una contraseña")) && !(passVald.Equals("Vuelva a ingresar la contraseña")))
            {
                labelResgistro_Message.Text = "Los elementos no pueden quedar vacíos";
                labelResgistro_Message.Visible = true;
                userLine.ForeColor = Color.Red;
            } //(caso  -, x ,-)
            else if (!(user.Equals("Ingrese un nombre de usuario")) && password.Equals("Ingrese una contraseña") && !(passVald.Equals("Vuelva a ingresar la contraseña")))
            {
                labelResgistro_Message.Text = "Los elementos no pueden quedar vacíos";
                labelResgistro_Message.Visible = true;
                passwordLine.ForeColor = Color.Red;

            } //(caso  -, - ,x)
            else if (!(user.Equals("Ingrese un nombre de usuario")) && !(password.Equals("Ingrese una contraseña")) && passVald.Equals("Vuelva a ingresar la contraseña"))
            {
                labelResgistro_Message.Text = "Los elementos no pueden quedar vacíos";
                labelResgistro_Message.Visible = true;
                passvalidLine.ForeColor = Color.Red;
            } //(caso  -, x ,x)
            else if (!(user.Equals("Ingrese un nombre de usuario")) && password.Equals("Ingrese una contraseña") && passVald.Equals("Vuelva a ingresar la contraseña"))
            {
                labelResgistro_Message.Text = "Los elementos no pueden quedar vacíos";
                labelResgistro_Message.Visible = true;
                passwordLine.ForeColor = Color.Red;
                passvalidLine.ForeColor = Color.Red;

            } //(caso  x, - ,x)
            else if (user.Equals("Ingrese un nombre de usuario") && !(password.Equals("Ingrese una contraseña")) && passVald.Equals("Vuelva a ingresar la contraseña"))
            {
                labelResgistro_Message.Text = "Los elementos no pueden quedar vacíos";
                labelResgistro_Message.Visible = true;
                userLine.ForeColor = Color.Red;
                passvalidLine.ForeColor = Color.Red;

            } //(caso  x, x ,-)
            else if (user.Equals("Ingrese un nombre de usuario") && password.Equals("Ingrese una contraseña") && !(passVald.Equals("Vuelva a ingresar la contraseña")))
            {
                labelResgistro_Message.Text = "Los elementos no pueden quedar vacíos";
                labelResgistro_Message.Visible = true;
                passwordLine.ForeColor = Color.Red;
                passvalidLine.ForeColor = Color.Red;

            } // comprobar que el usuario ingresado no exista
            else if (existe == true)
            {
                labelResgistro_Message.Text = "      El usuario ingresado, ya existe";
                labelResgistro_Message.Visible = true;
                userLine.ForeColor = Color.Red;

            } //comprobar si la contraseña se ha vuelto a escribir correctamente
            else if (!(password.Equals(passVald))) 
            {
                labelResgistro_Message.Text = "       Las contraseñas no coinciden";
                labelResgistro_Message.Visible = true;
                passvalidLine.ForeColor = Color.Red;

            } // enviamos los dato al archivo usuarios.txt  (caso  -, - ,-)
            else
            {
                StreamWriter escritura = File.AppendText(ruta);
                escritura.WriteLine( user + ',' + password);
                escritura.Close();
                labelResgistro_Message.Visible = true;
                textBox_UserRegister.Text = "";
                textBox_PasswordRegister.Text = "";
                textBox_PasswordConfirm.Text = "";
                btn_regresarLogin.LinkColor = Color.White;
                textBox_PasswordConfirm.Focus();
                textBox_PasswordRegister.Focus();
                textBox_UserRegister.Focus();
                passwordLine.ForeColor = Color.White;
                labelResgistro_Message.Text = "            REGISTRO EXITOSO";

            }
 

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
        // Eventos para crear efecto placeholder en los textbox del formulario
        private void textBox_UserRegister_Enter(object sender, EventArgs e)
        {
            // Si mi texbox no esta vacio, al hacer click se vaciara
            if (textBox_UserRegister.Text == "Ingrese un nombre de usuario")
            {
                textBox_UserRegister.Text = "";
            }

            textBox_UserRegister.ForeColor = Color.White;
            userLine.ForeColor = Color.White;
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
            passwordLine.ForeColor = Color.White;
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
            passvalidLine.ForeColor = Color.White;
        }
        private void textBox_PasswordConfirm_Leave(object sender, EventArgs e)
        {
            if (textBox_PasswordConfirm.Text == "")
            {
                textBox_PasswordConfirm.Text = "Vuelva a ingresar la contraseña";
                textBox_PasswordConfirm.ForeColor = Color.Gray;
            }
        }
        //Eventos para retroalimentar al usuario sin necesidad de oprimir el botón registrar
        private void textBox_PasswordRegister_TextChanged(object sender, EventArgs e)
        {
            if (textBox_PasswordRegister.Text.Equals("Ingrese una contraseña"))
            {
                labelResgistro_Message.Text = "Los elementos no pueden quedar vacíos";
                labelResgistro_Message.Visible = true;
                passwordLine.ForeColor = Color.Red;
            }
        
        string password = textBox_PasswordRegister.Text;

            //validar contraseña segura utilizando expresiones regulares...

            // se definen las expresiones regulares
            var hasNumber = new Regex(@"[0-9]");
            var hasUpperChar = new Regex(@"[A-Z]");
            var hasMinChar = new Regex(@".{8}");
            var hasLowerChar = new Regex(@"[a-z]");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            // encontramos las coincidencias de password para cada expresión regular
            MatchCollection hasNumberMatches = hasNumber.Matches(password);
            MatchCollection hasUpperCharMatches = hasUpperChar.Matches(password);
            MatchCollection LowerCharMatches = hasLowerChar.Matches(password);
            MatchCollection hasSymbolsMatches = hasSymbols.Matches(password);

            // se asigna un nivel de seguridad según los requisitos cubiertos
            int levelSecure = 0;

            if (!(LowerCharMatches.Count < 2))
            {
                levelSecure += 1;
            }
            if (!(hasUpperCharMatches.Count < 2))
            {
                levelSecure += 1;
            }
            if (hasMinChar.IsMatch(password))
            {
                levelSecure += 1;
            }
            if (!(hasNumberMatches.Count < 2))
            {
                levelSecure += 1;
            }
            if (!(hasSymbolsMatches.Count < 2))
            {
                levelSecure += 1;
            }

            if (textBox_PasswordRegister.Text.Equals("Ingrese una contraseña"))
            {
                levelSecure = 0;
            }

            // el nivel de seguridad se muestran al usuario a travez de una barra
            switch (levelSecure)
            {
                case 1:
                    labelRegistro_pass.Visible = true;
                    labelRegistro_pass.Text = "muy débil";
                    labelRegistro_pass.ForeColor = Color.Red;
                    panel1.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    panel1.BackColor = Color.Red;
                    break;
                case 2:
                    labelRegistro_pass.Visible = true;
                    labelRegistro_pass.Text = "débil";
                    labelRegistro_pass.ForeColor = Color.Orange;
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    panel1.BackColor = Color.Orange;
                    panel2.BackColor = Color.Orange;
                    break;
                case 3:
                    labelRegistro_pass.Visible = true;
                    labelRegistro_pass.Text = "buena";
                    labelRegistro_pass.ForeColor = Color.Yellow;
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    panel2.BackColor = Color.Yellow;
                    panel1.BackColor = Color.Yellow;
                    panel3.BackColor = Color.Yellow;
                    break;
                case 4:
                    labelRegistro_pass.Visible = true;
                    labelRegistro_pass.Text = "fuerte";
                    labelRegistro_pass.ForeColor = Color.GreenYellow;
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = true;
                    panel5.Visible = false;
                    panel2.BackColor = Color.GreenYellow;
                    panel1.BackColor = Color.GreenYellow;
                    panel3.BackColor = Color.GreenYellow;
                    panel4.BackColor = Color.GreenYellow;
                    break;
                case 5:
                    labelRegistro_pass.Visible = true;
                    labelRegistro_pass.Text = "muy fuerte";
                    labelRegistro_pass.ForeColor = Color.LawnGreen;
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = true;
                    panel5.Visible = true;
                    panel2.BackColor = Color.LawnGreen;
                    panel1.BackColor = Color.LawnGreen;
                    panel3.BackColor = Color.LawnGreen;
                    panel4.BackColor = Color.LawnGreen;
                    panel5.BackColor = Color.LawnGreen;
                    break;
                default:
                    labelRegistro_pass.Visible = false;
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    break;
            }
        }

        private void textBox_UserRegister_TextChanged(object sender, EventArgs e)
        {
            if (textBox_UserRegister.Text.Equals("Ingrese un nombre de usuario"))
            {
                labelResgistro_Message.Text = "Los elementos no pueden quedar vacíos";
                labelResgistro_Message.Visible = true;
                userLine.ForeColor = Color.Red;
            }
        }

        private void textBox_PasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            if (textBox_PasswordConfirm.Text.Equals("Ingrese un nombre de usuario"))
            {
                labelResgistro_Message.Text = "Los elementos no pueden quedar vacíos";
                labelResgistro_Message.Visible = true;
                userLine.ForeColor = Color.Red;
            }
        }
    }
}
