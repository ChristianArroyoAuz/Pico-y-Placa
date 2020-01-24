using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System;


namespace Pico_y_Placa
{
    public partial class PyP : Form
    {
        private bool placa = false;
        private bool fecha = false;
        private bool hora = false;
        private int ubicacion = 0;
        private string provincia;
        private int segunda = 0;
        private int digito = 0;
        private string circula;
        private string color;
        private string dia;
        private string mes;

        private void TxtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (txtPlaca.MaskCompleted == false || txtFecha.MaskCompleted == false || txtHora.MaskCompleted == false)
            {
                MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
            else
            {
                if (placa == true && fecha == true && hora == true)
                {
                    MessageBox.Show("La placa " + txtPlaca.Text + " pertenece a la provincia de: " + provincia + "." + "\n\n" +
                                     "El automotor es de tipo: " + color + "." + "\n\n" +
                                     "***************************************************************" + "\n\n" +
                                     "La fecha " + txtFecha.Text + " contine la siguiente información: " + "\n\n" +
                                     "Día: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dia) + ".     " +
                                     "Mes: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mes) + ".     " +
                                     "Año: " + txtFecha.Text.Substring(6, 4) + "." + "\n\n" +
                                     "***************************************************************" + "\n\n" +
                                     "Su automotor: " + circula + " en este día y horario.", "Resultado de la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Los datos ingresados son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
                LimpiarCampos();
            }
        }

        private void TxtPlaca_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPlaca.Text.Substring(0, 1) == "D" || txtPlaca.Text.Substring(0, 1) == "F" || txtPlaca.MaskCompleted == false)
                {
                    MessageBox.Show("La placa ingresada es invalida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    placa = false;
                }
                else
                {
                    string[] provincias = new string[] {"Azuay", "Bolivar", "Carchi", "Esmeraldas", "Guayas", "Chimborazo", "Imbabura",
                                                    "Santo Domingo de los Tsáchila", "Sucumbios", "Loja", "Manabi", "Napo", "El Oro",
                                                    "Pichicha", "Orellana", "Los Ríos", "Pastaza", "Tungurahua", "Cañar", "Morona Santiago",
                                                    "Galapagos", "Cotopaxi", "Santa Elena", "Zamora Chinchipe"};

                    string[] iniciales = new string[] {"A", "B", "C", "E", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                                                    "U", "V", "W", "X", "Y", "Z"};

                    string[] tipo = new string[] {"Vehículo Comercial (Taxi o Autobus)", "Vehículo Comercial (Taxi o Autobus)", "Vehículo Comercial (Taxi o Autobus)",
                                              "Vehículo Gubernamental",
                                              "Vehículo de uso Oficial",
                                              "Vehículo de Gobierno Autónomo Descentralizado",
                                              "Vehículo Particular"};

                    string[] segundaLetra = new string[] { "A", "U", "Z", "E", "X", "M" };

                    foreach (var item in iniciales)
                    {
                        ubicacion++;
                        if (item == txtPlaca.Text.Substring(0, 1))
                        {
                            provincia = provincias[ubicacion - 1].ToString();
                            break;
                        }
                    }

                    foreach (var item in segundaLetra)
                    {
                        segunda++;
                        if (item == txtPlaca.Text.Substring(1, 1))
                        {
                            color = tipo[segunda - 1].ToString();
                            break;
                        }
                        else
                        {
                            color = tipo[6].ToString();
                        }
                    }

                    placa = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                placa = false;
            }
        }

        private void TxtFecha_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime dias = new DateTime(Convert.ToInt32(txtFecha.Text.Substring(6, 4)), Convert.ToInt32(txtFecha.Text.Substring(3, 2)), Convert.ToInt32(txtFecha.Text.Substring(0, 2)));
                digito = (int)dias.DayOfWeek;
                dia = dias.ToString("dddd");
                mes = dias.ToString("MMMM");
                fecha = true;
            }
            catch (Exception)
            {
                MessageBox.Show("La fecha ingresada es invalida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fecha = false;
            }
        }

        private void TxtHora_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtHora.Text.Substring(0, 2)) <= 23 && Convert.ToInt32(txtHora.Text.Substring(3, 2)) <= 59)
                {
                    DateTime dias = new DateTime(Convert.ToInt32(txtFecha.Text.Substring(6, 4)), Convert.ToInt32(txtFecha.Text.Substring(3, 2)), Convert.ToInt32(txtFecha.Text.Substring(0, 2)));
                    if ((int)dias.DayOfWeek == 0 || (int)dias.DayOfWeek == 6)
                    {
                        circula = "PUEDE CIRCULAR";
                    }
                    else
                    {
                        if ((int)dias.DayOfWeek == 1 && (Convert.ToInt32(txtPlaca.Text.Substring(7, 1)) == 1 || Convert.ToInt32(txtPlaca.Text.Substring(7, 1)) == 2))
                        {
                            VerificarHora();
                        }
                        else
                        {
                            if ((int)dias.DayOfWeek == 2 && (Convert.ToInt32(txtPlaca.Text.Substring(7, 1)) == 3 || Convert.ToInt32(txtPlaca.Text.Substring(7, 1)) == 4))
                            {
                                VerificarHora();
                            }
                            else
                            {
                                if ((int)dias.DayOfWeek == 3 && (Convert.ToInt32(txtPlaca.Text.Substring(7, 1)) == 5 || Convert.ToInt32(txtPlaca.Text.Substring(7, 1)) == 6))
                                {
                                    VerificarHora();
                                }
                                else
                                {
                                    if ((int)dias.DayOfWeek == 4 && (Convert.ToInt32(txtPlaca.Text.Substring(7, 1)) == 7 || Convert.ToInt32(txtPlaca.Text.Substring(7, 1)) == 8))
                                    {
                                        VerificarHora();
                                    }
                                    else
                                    {
                                        if ((int)dias.DayOfWeek == 5 && (Convert.ToInt32(txtPlaca.Text.Substring(7, 1)) == 9 || Convert.ToInt32(txtPlaca.Text.Substring(7, 1)) == 0))
                                        {
                                            VerificarHora();
                                        }
                                        else
                                        {
                                            circula = "PUEDE CIRCULAR";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    hora = true;
                }
                else
                {
                    MessageBox.Show("La hora ingresada es invalida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hora = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("La hora ingresada es invalida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hora = false;
            }
        }

        private void LimpiarCampos()
        {
            provincia = String.Empty;
            circula = String.Empty;
            color = String.Empty;
            dia = String.Empty;
            mes = String.Empty;
            txtPlaca.Clear();
            txtFecha.Clear();
            txtPlaca.Focus();
            txtHora.Clear();
            fecha = false;
            placa = false;
            ubicacion = 0;
            hora = false;
            segunda = 0;
            digito = 0;
        }

        private void VerificarHora()
        {
            DateTime hora_0 = Convert.ToDateTime(txtHora.Text);
            DateTime hora_1 = Convert.ToDateTime("7:00");
            DateTime hora_2 = Convert.ToDateTime("9:30");
            DateTime hora_3 = Convert.ToDateTime("16:00");
            DateTime hora_4 = Convert.ToDateTime("19:30");

            if ((hora_0 >= hora_1 && hora_0 <= hora_2) || (hora_0 >= hora_3 && hora_0 <= hora_4))
            {
                circula = "NO PUEDE CIRCULAR";
            }
            else
            {
                circula = "PUEDE CIRCULAR";
            }
        }

        public PyP()
        {
            InitializeComponent();
        }
    }
}