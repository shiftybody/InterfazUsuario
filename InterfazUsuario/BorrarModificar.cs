using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
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
            // --------Solución a la modificación de archivos ----------
            string id = textBoxMod_ID.Text;
            string fecha = textBoxMod_Date.Text;
            string precip = textBoxMod_Preci.Text;
            string evap = textBoxMod_Evap.Text;
            string tMax = textBoxMod_Tmax.Text;
            string tMin = textBoxMod_Tmin.Text;
            string ruta = Ruta.rutaEstacion;

            StreamReader lectura = File.OpenText(ruta);
            string contenido = lectura.ReadToEnd();
            lectura.Close();
            string[] climas = contenido.Split('\n');

            for (int x = 0; x < (climas.Length - 1); x++)
            {
                string[] clima = climas[x].Split(',');

                if (clima[0].Trim().Equals(id))
                {
                    climas[x] = id + ',' + fecha + ',' + precip + ',' + evap + ',' + tMax + ',' + tMin + ',' + "1";

                    StreamWriter escritura = File.CreateText(ruta);

                    for (int y = 0; y < (climas.Length - 1); y++)
                    {
                        escritura.WriteLine(climas[y].Trim());
                    }
                    escritura.Close();

                    labelMod_Message.Text = " Registro Modificado";
                    labelMod_Message.Visible = true;
                    btnMod_Eliminar.Enabled = true;
                    break;
                }
            }   
        }

        private void btnMod_Buscar_Click(object sender, EventArgs e)
        {
            // -------- Solución a la busqueda de archivos ----------

            // si la propidad text del botón de busqueda es "NUEVA BUSQUEDA"
            if (btnMod_Buscar.Text.Equals("NUEVA BUSQUEDA"))
            {
                // los campos de los texbox se vaciaran 
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
                labelMod_MessageBusqueda.Visible = false;
                textBoxMod_ID.Focus();

                btnMod_Buscar.Text = "BUSCAR";

                btnMod_Eliminar.Enabled = true;
                labelMod_Message.Visible = false;

                btnMod_Eliminar.FlatStyle = FlatStyle.Standard;
                btnMod_Eliminar.BackColor = Color.Gainsboro;
                btnMod_Eliminar.Enabled = true;

                btnAnswer.Visible = false;
                btnAnswerN.Visible = false;
                btnMod_Guardar.Visible = true;
                labelMod_Message.Visible = false;
            }

            // Sino realizaremos la estructura de busqueda en el archivo estacion.txt
            else
            {
                labelMod_Message.Visible = false;
                // declramos las variables de busqueda
                string id = textBoxMod_ID.Text;
                string fecha = textBoxMod_Date.Text;
                string ruta = Ruta.rutaEstacion;

                StreamReader lectura = File.OpenText(ruta);
                string contenido = lectura.ReadToEnd();
                lectura.Close();
                // declararemos el estado que utilizaremos para saber si la información de 
                // determinada ID ha sido "borrada"
                string estado = "1";

                // separamos cada linea en un array
                string[] climas = contenido.Split('\n');

                // dentro de un ciclo leemos los datos para cada linea
                for (int x = 0; x < (climas.Length - 1); x++)
                {
                    // separamos la informacion correspondiente a cada capo
                    string[] clima = climas[x].Split(',');

                    // si los campos de una línea no tienen el estado "eliminado" es decir 1
                    if (clima[6].Trim().Equals(estado))
                    {
                        // si los campos ID y fecha se encuentran en una misma línea
                        if (clima[0].Trim().Equals(id) && clima[1].Trim().Equals(fecha))
                        {
                            //se le indica al usuario
                            labelMod_MessageBusqueda.Text = "Estado de clima encontrado";
                            labelMod_MessageBusqueda.Visible = true;

                            // Se muestran los resultados de los otros 
                            // campos dentro de los textbox
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
                        // Si se ingresa un ID existente pero no se llena el campo feche
                        else if (clima[0].Trim().Equals(id) && fecha.Equals(""))
                        {
                            // Se le indica al usuario que debe ingresar una fecha
                            labelMod_MessageBusqueda.Text = "Ingrese la fecha a buscar";
                            labelMod_MessageBusqueda.Visible = true;

                        }// Si ninguno de los campos a sido llenado 
                        else if (id.Equals("") && fecha.Equals(""))
                        {
                            // Se le indica al usuario que debe llenar ambos campos
                            labelMod_MessageBusqueda.Text = "campos vacios";
                            labelMod_MessageBusqueda.Visible = true;

                        }// Si el campo ID no coincide con la fecha 
                        else if (clima[0].Trim().Equals(id) && !(clima[1].Trim().Equals(fecha)))
                        {
                            // Se le indica al usuario que la fecha no es consistente con el ID
                            labelMod_MessageBusqueda.Text = "la fecha no coincide";
                            labelMod_MessageBusqueda.Visible = true;

                        }// Si se ha ingresado una fecha que existe, estando el campo ID vacío 
                        else if (id.Equals("") && clima[1].Trim().Equals(fecha))
                        {
                            // Se le pide al usuario que ingrese un ID
                            labelMod_MessageBusqueda.Text = "ingrese un ID";
                            labelMod_MessageBusqueda.Visible = true;
                        }// Lo mismo ocurre para el caso en que la fecha no existe y el ID no ha sido ingresado
                        else if (id.Equals("") && !(clima[1].Trim().Equals(fecha)))
                        {
                            labelMod_MessageBusqueda.Text = "ingrese un ID";
                            labelMod_MessageBusqueda.Visible = true;
                        }

                    } // Si ninguno de los casos anteriores ocurre, significa que la línea
                    //de los campos ha sido declarada como eliminada es decir valor 0
                    else
                    {
                        labelMod_MessageBusqueda.Text = "El estado de clima no existe";
                        labelMod_MessageBusqueda.Visible = true;
                    }

                }
            }



        }
        // El formulario cuenta con un checkBox que sirve para saber si el valor de evaporación es nulo
        private void checkBoxMod_Nulo_CheckedChanged(object sender, EventArgs e)
        {   // si el check box no ha sido seleccionado se mostrara el valor ingresado en un textbox
            if (checkBoxMod_Nulo.Checked == false)
            {
                textBoxMod_Evap.Enabled = true;
                textBoxMod_Evap.Text = "";
                textBoxMod_Evap.Focus();

            }// si el check box ha sido seleccionado, el texbox se desabilitara
            else
            {
                textBoxMod_Evap.Enabled = false;
                textBoxMod_Evap.Text = "Nulo";
            }
        }

        //Evento que nos permite detectar cuando hemos seleccionado una fecha en el calenario
        private void monthCalendarMod_Date_DateSelected(object sender, DateRangeEventArgs e)
        {
            //La fecha seleccionada se le asigna a un texbox
            textBoxMod_Date.Text = monthCalendarMod_Date.SelectionRange.Start.ToShortDateString();
        }

        private void btnMod_Eliminar_Click(object sender, EventArgs e)
        {
            // --------Solución a la baja de archivos ----------

            string id = textBoxMod_ID.Text;
            string ruta = Ruta.rutaEstacion;

            StreamReader lectura = File.OpenText(ruta);
            string contenido = lectura.ReadToEnd();
            lectura.Close();

            string[] climas = contenido.Split('\n');

            // dentro de un ciclo leemos los datos para cada linea
            for (int x = 0; x < (climas.Length - 1); x++)
            {
                // separamos la informacion correspondiente a cada capo
                string[] clima = climas[x].Split(',');

                if (clima[0].Trim().Equals(id))
                {

                    string fecha = textBoxMod_Date.Text;
                    string precip = textBoxMod_Preci.Text;
                    string evap = textBoxMod_Evap.Text;
                    string tMax = textBoxMod_Tmax.Text;
                    string tMin = textBoxMod_Tmin.Text;

                    if (fecha == clima[1] &&
                         precip == clima[2] &&
                         evap == clima[3] &&
                         tMax == clima[4] &&
                         tMin == clima[5]
                        )
                    {
                        btnMod_Eliminar.FlatStyle = FlatStyle.Flat;
                        btnMod_Eliminar.FlatAppearance.BorderSize = 0;
                        btnMod_Eliminar.BackColor = Color.IndianRed;
                        btnMod_Eliminar.Enabled = false;

                        btnAnswer.Visible = true;
                        btnAnswerN.Visible = true;
                        btnMod_Guardar.Visible = false;

                        labelMod_Message.Text = "Esta seguro que desea eliminarlo ?";
                        labelMod_Message.Visible = true;

                       
                    }
                    else
                    {
                        labelMod_Message.Text = "Guarde los cambios antes de continuar";
                        labelMod_Message.Visible = true;
                        btnMod_Eliminar.Enabled = false;
                        btnMod_Guardar.Focus();
                    }
                }

            }

        }

        private void form_modBajas_Load(object sender, EventArgs e)
        {

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            string id = textBoxMod_ID.Text;
            string fecha = textBoxMod_Date.Text;
            string precip = textBoxMod_Preci.Text;
            string evap = textBoxMod_Evap.Text;
            string tMax = textBoxMod_Tmax.Text;
            string tMin = textBoxMod_Tmin.Text;
            string ruta = Ruta.rutaEstacion;

            StreamReader lectura = File.OpenText(ruta);
            string contenido = lectura.ReadToEnd();
            lectura.Close();
            string[] climas = contenido.Split('\n');

            for (int x = 0; x < (climas.Length - 1); x++)
            {
                string[] clima = climas[x].Split(',');

                if (clima[0].Trim().Equals(id))
                {
 
                    climas[x] = id + ',' + fecha + ',' + precip + ',' + evap + ',' + tMax + ',' + tMin + ',' + "0" ;
                    StreamWriter escritura = File.CreateText(ruta);

                    for (int y = 0; y < (climas.Length - 1); y++)
                    {
                        escritura.WriteLine(climas[y].Trim());
                    }
                    escritura.Close();

                    labelMod_Message.Text = " Registro Eliminado ";
                    labelMod_Message.Visible = true;

                    btnMod_Eliminar.FlatStyle = FlatStyle.Standard;
                    btnMod_Eliminar.BackColor = Color.Gainsboro;
                    btnMod_Eliminar.Enabled = true;

                    btnAnswer.Visible = false;
                    btnAnswerN.Visible = false;
                    btnMod_Guardar.Visible = true;

                    // los campos de los texbox se vaciaran 
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
                    labelMod_MessageBusqueda.Visible = false;
                    textBoxMod_ID.Focus();

                    btnMod_Buscar.Text = "BUSCAR";

                    break;
                }      
            }
        }

        private void btnAnswerN_Click(object sender, EventArgs e)
        {
            btnMod_Eliminar.FlatStyle = FlatStyle.Standard;
            btnMod_Eliminar.BackColor = Color.Gainsboro;
            btnMod_Eliminar.Enabled = true;

            btnAnswer.Visible = false;
            btnAnswerN.Visible = false;
            btnMod_Guardar.Visible = true;
            labelMod_Message.Visible = false;

        }
    }
}
