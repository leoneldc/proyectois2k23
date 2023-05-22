using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Cotizacion : Form
    {
        public Cotizacion()
        {
            InitializeComponent();
            cargar();
        }

        CapaModelo_Ventas.Cpconexion conexion = new CapaModelo_Ventas.Cpconexion();
        CapaControlador_Alumnos.CpControlador controlador = new CapaControlador_Alumnos.CpControlador();
        void displayDatos()
        {
            DataTable data = controlador.MostrarReportes();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Sucursal";
            dataGridView1.Columns[1].HeaderText = "iD Cliente";
            dataGridView1.Columns[1].HeaderText = "Detalle de venta";
        }
        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1000";
            TextBox[] Grupotextbox = { txt_id, txt_sucursal, txt_idcliente, txt_detalleventa };
            TextBox[] Idtextbox = { txt_id, txt_sucursal };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_cotizacion");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void cargar()
        {
            string sql = "SELECT * FROM " + dataGridView1.Tag + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.Conexion());
            DataTable table = new DataTable();
            dataTable.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
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
            controlador.Guardar(valoresPorTagTabla, valoresPorTagColumnas);

            cargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> valoresPorTagTabla = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> valoresPorTagColumnas = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> valoresPorTagCondicion = new Dictionary<string, List<string>>();

            TextBox id2 = new TextBox();
            id2.Text = txt_id.Text;
            id2.Tag = "test2,id2,primary";

            TextBox[] arreglo = { txt_id, txt_idCotizacion, txt_CodigoProducto, txt_Cantidad, txt_Precio, txt_total, txt_Estado, id2 };


            foreach (TextBox textBox in arreglo)
            {
                string[] datosTextBox = textBox.Tag.ToString().Split(',');
                string tabla = datosTextBox[0];
                string columna = datosTextBox[1];
                string valor = textBox.Text;
                if (!valoresPorTagTabla.ContainsKey(tabla))
                {
                    valoresPorTagTabla[tabla] = new List<string>();
                    valoresPorTagColumnas[tabla] = new List<string>();
                    valoresPorTagCondicion[tabla] = new List<string>();
                }
                valoresPorTagTabla[tabla].Add(columna);
                valoresPorTagColumnas[tabla].Add("\'" + valor + "\'");
                if (textBox.Tag.ToString().Contains("primary"))
                {
                    valoresPorTagCondicion[tabla].Add(columna);
                }
            }
            controlador.Actualizar(valoresPorTagTabla, valoresPorTagColumnas, valoresPorTagCondicion);

            cargar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> valoresPorTagTabla = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> valoresPorTagColumnas = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> valoresPorTagCondicion = new Dictionary<string, List<string>>();


            TextBox id2 = new TextBox();
            id2.Text = txt_id.Text;
            id2.Tag = "test2,id2,primary";

            TextBox[] arreglo = { txt_id, txt_idCotizacion, txt_CodigoProducto, txt_Cantidad, txt_Precio, txt_total, txt_Estado, id2 };

            foreach (TextBox textBox in arreglo)
            {
                string[] datosTextBox = textBox.Tag.ToString().Split(',');
                string tabla = datosTextBox[0];
                string columna = datosTextBox[1];
                string valor = textBox.Text;
                if (!valoresPorTagTabla.ContainsKey(tabla))
                {
                    valoresPorTagTabla[tabla] = new List<string>();
                    valoresPorTagColumnas[tabla] = new List<string>();
                    valoresPorTagCondicion[tabla] = new List<string>();
                }
                valoresPorTagTabla[tabla].Add(columna);
                valoresPorTagColumnas[tabla].Add("\'" + valor + "\'");
                if (textBox.Tag.ToString().Contains("primary"))
                {
                    valoresPorTagCondicion[tabla].Add(columna);
                }
            }
            controlador.Eliminar(valoresPorTagTabla, valoresPorTagColumnas, valoresPorTagCondicion);
            cargar();
        }
    }
}
