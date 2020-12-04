using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace InterfazUsuario
{
    public partial class form_Menu : Form
    {
        public form_Menu()
        {
            InitializeComponent();

        }
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

        private void panel_Contenedor_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnMenu_logout_Click(object sender, EventArgs e)
        {
            form_Login abrir = new form_Login();
            abrir.Show();
            this.Hide();

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void form_Menu_Load(object sender, EventArgs e)
        {
            AbrirForm(new form_Altas());
            btnMenu_Crear.BackColor = Color.Gray;
            btnMenu_Crear.FlatAppearance.MouseOverBackColor = Color.Gray;
        }


    }
}
