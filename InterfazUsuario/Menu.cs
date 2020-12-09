using System;
using System.Drawing;
using System.Windows.Forms;


namespace InterfazUsuario
{
    public partial class form_Menu : Form
    {
        public form_Menu()
        {
            InitializeComponent();

        }
        //Metodo creado para abrir formulario dentro del panel del menu principal
        private void AbrirForm (object formHijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
            {
                this.panel_Contenedor.Controls.RemoveAt(0);
            }                     
                Form fh = formHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel_Contenedor.Controls.Add(fh);
                this.panel_Contenedor.Tag = fh;
                fh.Show();
            
        }
        //Para cada botón se manda llamar al método y se establece un cambio de apariencia para conocer el formulario abierto
        private void btn_Crear_Click(object sender, EventArgs e) //este es el btnMenu_Crear
        {
            AbrirForm(new form_Altas());

            btnMenu_Crear.BackColor = Color.Gray;
            btnMenu_modElim.BackColor = Color.FromArgb(33,33,33);
            btnMenu_creditos.BackColor = Color.FromArgb(33,33,33);

            btnMenu_Crear.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMenu_modElim.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64); 
            btnMenu_creditos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);

        }

        private void btnMenu_modElim_Click(object sender, EventArgs e)
        {
            AbrirForm(new form_modBajas());

            btnMenu_modElim.BackColor = Color.Gray;
            btnMenu_creditos.BackColor = Color.FromArgb(33, 33, 33);
            btnMenu_Crear.BackColor = Color.FromArgb(33, 33, 33);

            btnMenu_modElim.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMenu_creditos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMenu_Crear.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnMenu_creditos_Click(object sender, EventArgs e)
        {
            AbrirForm(new form_Creditos());

            btnMenu_creditos.BackColor = Color.Gray;
            btnMenu_modElim.BackColor = Color.FromArgb(33, 33, 33);
            btnMenu_Crear.BackColor = Color.FromArgb(33, 33, 33);

            btnMenu_creditos.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMenu_modElim.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMenu_Crear.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        }
        //Evento que cierra el menú para acceder nuevamente al login
        private void btnMenu_logout_Click(object sender, EventArgs e)
        {
            form_Login abrir = new form_Login();
            abrir.Show();
            this.Hide();

        }
        //Evento que finaliza la aplicacion al seleccionar el botón superior derecho
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Evento que ocurre la primera vez que se abre el forulario
        // este indica que debe llamar al formulario altas para que aparezca al principio
        private void form_Menu_Load(object sender, EventArgs e)
        {
            AbrirForm(new form_Altas());
            btnMenu_Crear.BackColor = Color.Gray;
            btnMenu_Crear.FlatAppearance.MouseOverBackColor = Color.Gray;
        }


    }
}
