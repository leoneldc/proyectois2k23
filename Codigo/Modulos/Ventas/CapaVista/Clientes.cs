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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        CapaControlador_Alumnos.CpControlador controlador = new CapaControlador_Alumnos.CpControlador();

        void displayDatos()
        {
            DataTable data = controlador.MostrarReportes();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "DPI";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].HeaderText = "Apellidos";
            dataGridView1.Columns[1].HeaderText = "Fecha nacimiento";
            dataGridView1.Columns[5].HeaderText = "NIT";
            dataGridView1.Columns[1].HeaderText = "Estado";
            dataGridView1.Columns[2].HeaderText = "Direccion";
            dataGridView1.Columns[3].HeaderText = "Telefono";           
            dataGridView1.Columns[5].HeaderText = "Vendedor";
            dataGridView1.Columns[3].HeaderText = "Saldo mes anterior";
            dataGridView1.Columns[5].HeaderText = "Saldo actual";
            dataGridView1.Columns[3].HeaderText = "Cargo del mes";
            dataGridView1.Columns[5].HeaderText = "Abonos del mes";
            dataGridView1.Columns[3].HeaderText = "Cargos acumulados";
            dataGridView1.Columns[5].HeaderText = "Abonos acumulados";
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1000";
            TextBox[] Grupotextbox = { txt_id, txt_dpi, txt_nombre, txt_apellido, txt_fechanac, txt_nit, txt_estado, txt_direccion, txt_telefono, txt_vendedor, txt_smesanterior,txt_saldoactual,txt_cargomes,txt_abonomes,txt_cargosacum,txt_abonosacum };
            TextBox[] Idtextbox = { txt_id, txt_dpi };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_clientes");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAyudaClientes ayudaClientes = new MenuAyudaClientes();
            ayudaClientes.Show();
        }
    }
}
