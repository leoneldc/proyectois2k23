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
        public Cotizacion()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAyudaVendedores ayudaVendedores = new MenuAyudaVendedores();
            ayudaVendedores.Show();
        }
    }
}
