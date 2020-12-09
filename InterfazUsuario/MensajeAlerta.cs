using System;
using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class MensajeAlerta : Form
    {
        public MensajeAlerta()
        {
            InitializeComponent();
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (textBoxAlert_Message.Text.Equals(Ruta.noRuta))
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
            }

        }

        private void buttonAlert_Acept_Click(object sender, EventArgs e)
        {
              if (textBoxAlert_Message.Text.Equals(Ruta.noRuta))
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
            }

        }
    }
}
