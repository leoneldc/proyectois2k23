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
    public partial class DetalleCotizacion : Form
    {
        public DetalleCotizacion()
        {
            InitializeComponent();
        }

        CapaControlador_Alumnos.CpControlador controlador = new CapaControlador_Alumnos.CpControlador();

        void displayDatos()
        {
            DataTable data = controlador.MostrarReportes();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Id de cotizacion";
            dataGridView1.Columns[1].HeaderText = "Codigo de producto";
            dataGridView1.Columns[1].HeaderText = "Cantidad";
            dataGridView1.Columns[1].HeaderText = "Precio";
            dataGridView1.Columns[1].HeaderText = "Total";
            dataGridView1.Columns[2].HeaderText = "Estado";
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1000";
            TextBox[] Grupotextbox = { txt_Id, txt_idCotizacion, txt_CodigoProducto, txt_Cantidad, txt_Precio, txt_total, txt_Estado };
            TextBox[] Idtextbox = { txt_Id, txt_idCotizacion };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_detalle_cotizacion");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAyudaVendedores ayudaVendedores = new MenuAyudaVendedores();
            ayudaVendedores.Show();
        }
    }
}
