using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora_4_Problema_3
{
    public struct Persona
    {
        public string nombre;
        public string apellido;
        public string año;
        public string mes;
        public string dia;

        public Persona(string sNombre, string sApellido, string sAño, string sMes, string sDia)
        {
            nombre = sNombre;
            apellido = sApellido;
            año = sAño;
            mes = sMes;
            dia = sDia;
        }
    }
    public partial class Form1 : Form
    {
        Persona[] persona = new Persona[8];
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
            lblContador.Text = contador.ToString();
            txtNombre.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    persona[contador] = new Persona();
                    persona[contador].nombre = txtNombre.Text;
                    persona[contador].apellido = txtApellido.Text;
                    persona[contador].año = txtAño.Text;
                    persona[contador].mes = txtMes.Text;
                    persona[contador].dia = txtDia.Text;
                    contador++;
                    lblContador.Text = contador.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Debe capturar antes los datos","Alerta");
                }
            }
            else
            {
                MessageBox.Show("Ya no puede registrar a mas usuarios", "Alerta");
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtNombre.Focus();
            txtApellido.Text = string.Empty;
            txtAño.Text = string.Empty;
            txtMes.Text = string.Empty;
            txtDia.Text = string.Empty;
        }

        private void btnInteractuar_Click(object sender, EventArgs e)
        {
            string sDato = string.Empty;
            for (int i= 0; i<8; i++)
            {
                if (txtMesCumpleaños.Text == "0")
                {
                    MessageBox.Show("Fin de Interaccion");
                    return;
                }
                else
                { 
                    if (Convert.ToInt32(persona[i].mes) == Convert.ToInt32(txtMesCumpleaños.Text))
                    {
                        sDato = string.Format("{0}\r\n{1}", sDato,persona[i].nombre);
                    }
                }
            }
            rtbCumpleñeros.Text = sDato;
        }
    }
}
