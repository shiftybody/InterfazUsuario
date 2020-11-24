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
    }
}
