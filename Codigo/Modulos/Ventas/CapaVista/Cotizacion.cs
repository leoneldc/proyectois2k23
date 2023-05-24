using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaVista
{
    public partial class Cotizacion : Form
    {
        CapaModelo_Ventas.Sentencias sn = new CapaModelo_Ventas.Sentencias();
        public Cotizacion()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            txt_id.Text = txt_id.Text;
            txt_almacen_encabezado.Text = txt_id.Text;
            txt_id_detalle_cotizacion.Text = txt_id.Text;
            Dictionary<string, List<string>> valoresPorTagTabla = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> valoresPorTagColumnas = new Dictionary<string, List<string>>();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && textBox.Tag != null)
                {
                    string[] datosTextBox = textBox.Tag.ToString().Split(',');
                    string tabla = datosTextBox[0];
                    string columna = datosTextBox[1];
                    string condicion = datosTextBox.Length == 3 ? datosTextBox[2] : "";
                    string valor = textBox.Text;
                    if (!valoresPorTagTabla.ContainsKey(tabla))
                    {
                        valoresPorTagTabla[tabla] = new List<string>();
                        valoresPorTagColumnas[tabla] = new List<string>();
                    }
                    valoresPorTagTabla[tabla].Add(columna);
                    valoresPorTagColumnas[tabla].Add("\'" + valor + "\'");
                }
            }
            sn.Guardar(valoresPorTagTabla, valoresPorTagColumnas);
        }
    }
}
