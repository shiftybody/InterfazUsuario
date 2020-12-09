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
    public partial class form_modBajas : Form
    {
        public form_modBajas()
        {
            InitializeComponent();
        }

        private void btnMod_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void btnMod_Buscar_Click(object sender, EventArgs e)
        {

            if (btnMod_Buscar.Text.Equals("NUEVA BUSQUEDA"))
            {
                textBoxMod_ID.Enabled = true;
                textBoxMod_ID.Text = "";
                textBoxMod_Date.Text = "";
                textBoxMod_Preci.Text = "";

                if (textBoxMod_Evap.Text.Equals("Nulo"))
                {
                    checkBoxMod_Nulo.Checked = false;
                }
                else
                {
                    textBoxMod_Evap.Text = "";
                }

                textBoxMod_Tmax.Text = "";
                textBoxMod_Tmin.Text = "";
                labelMod_MessageBusqueda.Visible = true;
                textBoxMod_ID.Focus();

            }
            else
            {
                string id = textBoxMod_ID.Text;
                string fecha = textBoxMod_Date.Text;
                string ruta = Ruta.rutaEstacion;

                StreamReader lectura = File.OpenText(ruta);
                string contenido = lectura.ReadToEnd();
                lectura.Close();
                string estado = "1";

                // separamos cada usuario registrado en un array
                string[] climas = contenido.Split('\n');

                // dentro de un ciclo leemos los datos
                for (int x = 0; x < (climas.Length - 1); x++)
                {
                    // separamos la informacion 
                    string[] clima = climas[x].Split(',');

                    // si el usuario existe, la variable existe sera igual a true
                    if (clima[6].Trim().Equals(estado))
                    {
                        if (clima[0].Trim().Equals(id) && clima[1].Trim().Equals(fecha))
                        {
                            labelMod_MessageBusqueda.Text = "Estado de clima encontrado";
                            labelMod_MessageBusqueda.Visible = true;
                            textBoxMod_Preci.Text = clima[2];

                            if (clima[3].Equals("Nulo"))
                            {
                                checkBoxMod_Nulo.Checked = true;
                            }
                            else
                            {
                                textBoxMod_Evap.Text = clima[3];
                            }

                            textBoxMod_Tmax.Text = clima[4];
                            textBoxMod_Tmin.Text = clima[5];

                            btnMod_Buscar.Text = "NUEVA BUSQUEDA";
                            textBoxMod_ID.Enabled = false;


                        }
                        else if (clima[0].Trim().Equals(id) && fecha.Equals(""))
                        {
                            labelMod_MessageBusqueda.Text = "Ingrese la fecha a buscar";
                            labelMod_MessageBusqueda.Visible = true;

                        }
                        else if (id.Equals("") && fecha.Equals(""))
                        {

                            labelMod_MessageBusqueda.Text = "campos vacios";
                            labelMod_MessageBusqueda.Visible = true;
                        }
                        else if (clima[0].Trim().Equals(id) && !(clima[1].Trim().Equals(fecha)))
                        {
                            labelMod_MessageBusqueda.Text = "la fecha no coincide";
                            labelMod_MessageBusqueda.Visible = true;
                        }
                        else if (id.Equals("") && clima[1].Trim().Equals(fecha))
                        {
                            labelMod_MessageBusqueda.Text = "ingrese un ID";
                            labelMod_MessageBusqueda.Visible = true;
                        }
                        else if (id.Equals("") && !(clima[1].Trim().Equals(fecha)))
                        {
                            labelMod_MessageBusqueda.Text = "ingrese un ID";
                            labelMod_MessageBusqueda.Visible = true;
                        }

                    }
                    else
                    {
                        labelMod_MessageBusqueda.Text = "El estado de clima no existe";
                        labelMod_MessageBusqueda.Visible = true;
                    }

                }
            }

           

        }

        private void checkBoxMod_Nulo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMod_Nulo.Checked == false)
            {
                textBoxMod_Evap.Enabled = true;
                textBoxMod_Evap.Text = "";
                textBoxMod_Evap.Focus();
            }
            else
            {
                textBoxMod_Evap.Enabled = false;
                textBoxMod_Evap.Text = "Nulo";
            }
        }

        private void monthCalendarMod_Date_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxMod_Date.Text = monthCalendarMod_Date.SelectionRange.Start.ToShortDateString();
        }

        private void btnMod_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnMod_Buscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
