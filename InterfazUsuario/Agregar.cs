using System;
using System.Windows.Forms;
using System.IO;

namespace InterfazUsuario
{
    public partial class form_Altas : Form
    {
        public form_Altas()
        {
            InitializeComponent();
        }

        private void form_Altas_Load(object sender, EventArgs e)
        {
            //Utilizamos la clase StreamReader para leer y obtener
            //el ultimo ID correspondiente
            string ruta = Ruta.rutaEstacion;
            StreamReader lectura = File.OpenText(ruta);
            string contenido = lectura.ReadToEnd();
            lectura.Close();

            string[] ids = contenido.Split('\n');
            int id = ids.Length - 1;
            // sumamos 1 al id y lo despleguamos en su texbox
            id ++ ;

            textBoxAltas_ID.Text = Convert.ToString(id);

        }
        //Evento que nos permite detectar cuando hemos seleccionado una fecha en el calenario
        private void monthCalendarAltas_Date_DateSelected(object sender, DateRangeEventArgs e)
        {
            //La fecha seleccionada se le asigna a un texbox
            textBoxAltas_Date.Text = monthCalendarAltas_Date.SelectionRange.Start.ToShortDateString();
        }
        // El formulario cuenta con un checkBox que sirve para saber si el valor de evaporación es nulo
        private void checkBoxAltas_Nulo_CheckedChanged(object sender, EventArgs e)
        {   // si el check box no ha sido seleccionado se mostrara el valor ingresado en un textbox
            if(checkBoxAltas_Nulo.Checked == false)
            {
                textBoxAltas_Evap.Enabled = true;
                textBoxAltas_Evap.Text = "";
                textBoxAltas_Evap.Focus();
            }
            // si el check box ha sido seleccionado, el texbox se desabilitara
            else
            {
                textBoxAltas_Evap.Enabled = false;
                textBoxAltas_Evap.Text = "Nulo";
            }
        }

        private void btnAltas_Agregar_Click(object sender, EventArgs e)
        {
            string  id, fecha, precip, evap, tMax, tMin ;
            string ruta = Ruta.rutaEstacion;

            id = textBoxAltas_ID.Text;
            fecha = textBoxAltas_Date.Text;
            precip = textBoxAltas_Preci.Text;
            evap = textBoxAltas_Evap.Text;
            tMax = textBoxAltas_Tmax.Text;
            tMin = textBoxAltas_Tmin.Text;


            if (id.Equals("") ||
                fecha.Equals("") ||
                precip.Equals("") ||
                evap.Equals("") ||  
                tMax.Equals("") ||
                tMin.Equals("") )
            {
                labelAltas_Message.Text = "Todos los campos deben estar llenos ";
                labelAltas_Message.Visible = true;
            }
            else
            {
                StreamWriter escritura = File.AppendText(ruta);
                escritura.WriteLine(id + ',' + fecha + ',' + precip + ',' + evap + ',' + tMax + ',' + tMin + ',' + "1") ;
                escritura.Close();
                labelAltas_Message.Text = "           REGISTRO EXITOSO  ";
                labelAltas_Message.Visible = true;

                textBoxAltas_Date.Text = "";
                textBoxAltas_Preci.Text = "";
                checkBoxAltas_Nulo.Checked = false;
                textBoxAltas_Evap.Text = "";
                textBoxAltas_Tmax.Text = "";
                textBoxAltas_Tmin.Text = "";
                textBoxAltas_Date.Focus();

                int newid = int.Parse(id) ;
                newid++;
                textBoxAltas_ID.Text = Convert.ToString(newid);

            }
        }
    }
}
