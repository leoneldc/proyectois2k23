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
    public partial class Vendedores : Form
    {
        public Vendedores()
        {
            InitializeComponent();
        }
        CapaControlador_Alumnos.CpControlador controlador = new CapaControlador_Alumnos.CpControlador();

        void displayDatos()
        {
            DataTable data = controlador.MostrarReportes();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "DPI";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].HeaderText = "Apellidos";
            dataGridView1.Columns[1].HeaderText = "Estado";
            dataGridView1.Columns[1].HeaderText = "NIT";
            dataGridView1.Columns[2].HeaderText = "Edad";
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1000";
            TextBox[] Grupotextbox = { txt_Id, txt_DPI, txt_nombre, txt_Apellido, txt_estado, txt_nit, txt_Edad };
            TextBox[] Idtextbox = { txt_Id, txt_DPI };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_vendedores");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAyudaVendedores ayudaVendedores = new MenuAyudaVendedores();
            ayudaVendedores.Show();
        }
    }
}
