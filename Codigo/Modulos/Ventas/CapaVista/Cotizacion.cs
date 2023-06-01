﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas_CapaControlador;
using System.Data.Odbc;

namespace CapaVista
{
    public partial class Cotizacion : Form
    {
        Controlador controlador = new Controlador();
        CapaModelo_Ventas.Cpconexion conexion = new CapaModelo_Ventas.Cpconexion();
        int indice = 1;
        public void actualizarGrid()
        {
            string consultaEncabezado = "SELECT * FROM tbl_cotizacion;";
            OdbcCommand cmdEncabezado = new OdbcCommand(consultaEncabezado, conexion.Conexion());
            // Crear el adaptador de datos
            OdbcDataAdapter adapter = new OdbcDataAdapter(cmdEncabezado);

            // Crear el DataSet para almacenar los datos
            DataSet dataSet = new DataSet();

            // Llenar el DataSet con los datos del adaptador
            adapter.Fill(dataSet);

            // Asignar el DataSet como origen de datos del DataGridView
            dataGridView2.DataSource = dataSet.Tables[0];

            // Ajustar la apariencia de las columnas (opcional)
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public Cotizacion()
        {
            InitializeComponent();
            actualizarGrid();

            dataGridView1.ColumnCount = 4; // Establece el número de columnas

            dataGridView3.ColumnCount = 4; // Establece el número de columnas

            dataGridView3.Columns[0].Name = "Producto"; // Nombre de la primera columna
            dataGridView3.Columns[1].Name = "Cantidad"; // Nombre de la segunda columna
            dataGridView3.Columns[2].Name = "Precio Unitario"; // Nombre de la tercera columna
            dataGridView3.Columns[3].Name = "Subtotal"; // Nombre de la cuarta columna

            dataGridView1.Columns[0].Name = "Producto"; // Nombre de la primera columna
            dataGridView1.Columns[1].Name = "Cantidad"; // Nombre de la segunda columna
            dataGridView1.Columns[2].Name = "Precio Unitario"; // Nombre de la tercera columna
            dataGridView1.Columns[3].Name = "Subtotal"; // Nombre de la cuarta columna
            string numeroId = "SELECT Pk_idCotizacion FROM `ModuloVentas`.`tbl_cotizacion` ORDER BY Pk_idCotizacion DESC LIMIT 1;";
            string numeroIdDetalle = "SELECT Pk_detallecotizacion FROM `ModuloVentas`.`tbl_detalle_cotizacion` ORDER BY Pk_detallecotizacion DESC LIMIT 1;";

            string comboProductos = "select nombre_producto from `ModuloVentas`.`tbl_producto`";
            string comboAlmacen = "select nombre_almacen from `ModuloVentas`.`tbl_almacen`";
            string comboCliente = "select Dpi_clientes from `ModuloVentas`.`tbl_clientes`";
            string comboEstado = "select descripcion_estado_cotizacion from `ModuloVentas`.`tbl_estado_cotizacion`";
            try
            {
                OdbcCommand cmdId = new OdbcCommand(numeroId, conexion.Conexion());
                OdbcDataReader readerId = cmdId.ExecuteReader();

                while (readerId.Read())
                {
                    int idActual = int.Parse(readerId.GetString(0));
                    idActual = idActual + 1;
                    txt_id.Text = idActual.ToString();
                }

                OdbcCommand cmdIdDetalle = new OdbcCommand(numeroIdDetalle, conexion.Conexion());
                OdbcDataReader readerIdDetalle = cmdIdDetalle.ExecuteReader();

                while (readerIdDetalle.Read())
                {
                    int idActualDetalle = int.Parse(readerIdDetalle.GetString(0));
                    idActualDetalle = idActualDetalle + 1;
                    txt_id_detalle_cotizacion.Text = idActualDetalle.ToString();
                }

                OdbcCommand cmd = new OdbcCommand(comboAlmacen, conexion.Conexion());
                OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxAlmacen.Items.Add(reader.GetString(0));
                }


                OdbcCommand productos = new OdbcCommand(comboProductos, conexion.Conexion());
                OdbcDataReader readerProductos = productos.ExecuteReader();

                while (readerProductos.Read())
                {
                    comboBoxProducto.Items.Add(readerProductos.GetString(0));
                }


                OdbcCommand cliente = new OdbcCommand(comboCliente, conexion.Conexion());
                OdbcDataReader readerCliente = cliente.ExecuteReader();

                while (readerCliente.Read())
                {
                    comboBoxCliente.Items.Add(readerCliente.GetString(0));
                }
                OdbcCommand estado = new OdbcCommand(comboEstado, conexion.Conexion());
                OdbcDataReader readerEstado = estado.ExecuteReader();

                while (readerEstado.Read())
                {
                    comboBox4.Items.Add(readerEstado.GetString(0));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }
        }
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void Actualizar(Dictionary<string, List<string>> valoresPorTagTabla, Dictionary<string, List<string>> valoresPorTagColumnas, Dictionary<string, List<string>> condiciones)
        {
           

        }
        public void Eliminar(Dictionary<string, List<string>> valoresPorTagTabla, Dictionary<string, List<string>> valoresPorTagColumnas, Dictionary<string, List<string>> condiciones)
        {
            

        }
        public void Guardar(Dictionary<string, List<string>> valoresPorTagTabla, Dictionary<string, List<string>> valoresPorTagColumnas)
        {
          

        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {

            

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string productos = comboBoxProducto.SelectedItem.ToString();
            txt_producto.Text = productos;
            string dato1 = txt_producto.Text;
            string dato2 = txt_cantidad.Text;
            txt_precio.Text = controlador.obtenerPrecioUnitario(productos);
            string dato3 = txt_precio.Text;
            float numPrecio = float.Parse(dato3);
            float numCantidad = float.Parse(dato2);
            float subTotal = numPrecio * numCantidad;
            string dato4 = subTotal.ToString("F2"); //F2 indica que se deben mostrar dos decimales
            string[] row1 = { dato1, dato2, dato3, dato4 }; // Valores de la primera fila
            dataGridView1.Rows.Add(row1); // Agrega la primera fila
            string dato5 = txt_total.Text;
            float total = float.Parse(dato5);
            total = total + subTotal;
            txt_total.Text = total.ToString("F2");
            txt_cantidad_producto.Text = txt_cantidad.Text;
            txt_cantidad.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indice = dataGridView1.SelectedRows[0].Index;
                DataGridViewCell celdaSeleccionada = dataGridView1.SelectedCells[3];
                object valorCelda = celdaSeleccionada.Value;
                string dato4 = valorCelda.ToString();
                string dato5 = txt_total.Text;
                float total = float.Parse(dato5);
                float precioRestado = float.Parse(dato4);
                total = total - precioRestado;
                txt_total.Text = total.ToString();
                dataGridView1.Rows.RemoveAt(indice);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idCotizacion = txt_id.Text;
            DateTime fecha = dateTimePicker1.Value;
            txt_fecha.Text = fecha.ToString("yyyy/MM/dd"); // Formato de fecha deseado
            string nombreAlmacen = comboBoxAlmacen.SelectedItem.ToString();
            string idAlmacen = "SELECT codigo_almacen FROM `ModuloVentas`.`tbl_almacen` WHERE nombre_almacen = '" + nombreAlmacen + "';";
            OdbcCommand cmdAlmacen = new OdbcCommand(idAlmacen, conexion.Conexion());
            OdbcDataReader readerAlmacen = cmdAlmacen.ExecuteReader();

            while (readerAlmacen.Read())
            {
                string almacen = readerAlmacen.GetString(0);
                textBox1.Text = almacen;
            }
            string dpiCliente = comboBoxCliente.SelectedItem.ToString();
            string idCliente = "SELECT Pk_idClientes FROM `ModuloVentas`.`tbl_clientes` WHERE Dpi_clientes = '" + dpiCliente + "';";
            OdbcCommand cmdCliente = new OdbcCommand(idCliente, conexion.Conexion());
            OdbcDataReader readerCliente = cmdCliente.ExecuteReader();

            while (readerCliente.Read())
            {
                string cliente = readerCliente.GetString(0);
                textBox2.Text = cliente;
            }
            string cotizacion = "insert into `ModuloVentas`.`tbl_cotizacion` values (" + idCotizacion + "," + textBox1.Text + "," + textBox2.Text + ", '" + txt_fecha.Text + "');";
            OdbcCommand cmdInsertar = new OdbcCommand(cotizacion, conexion.Conexion());
            cmdInsertar.ExecuteNonQuery();


            string nombreEstado = comboBox4.SelectedItem.ToString();
            string idEstado = "SELECT Pk_estado_cotizacion FROM `ModuloVentas`.`tbl_estado_cotizacion` WHERE descripcion_estado_cotizacion = '" + nombreEstado + "';";
            OdbcCommand cmdEstado = new OdbcCommand(idEstado, conexion.Conexion());
            OdbcDataReader readerEstado = cmdEstado.ExecuteReader();

            while (readerEstado.Read())
            {
                string estado = readerEstado.GetString(0);
                txt_estado.Text = estado;
            }

            string[] nombreProducto, cantidad, precio, subTotal;
            int numeroFilas = dataGridView1.Rows.Count;
            nombreProducto = new string[numeroFilas];
            cantidad = new string[numeroFilas];
            precio = new string[numeroFilas];
            subTotal = new string[numeroFilas];

            for (int i = 0; i < numeroFilas; i++)
            {
                DataGridViewRow fila = dataGridView1.Rows[i];
                cantidad[i] = fila.Cells[1].Value.ToString();
                precio[i] = fila.Cells[2].Value.ToString();
                subTotal[i] = fila.Cells[3].Value.ToString();
                txt_cantidad_detalle.Text = cantidad[i];
                txt_total_detalle.Text = subTotal[i];
                txt_precio_detalle.Text = precio[i];
                // Obtener el valor de la celda deseada, por ejemplo, la primera celda de cada fila
                nombreProducto[i] = fila.Cells[0].Value.ToString();
                string idProducto = "SELECT codigo_producto FROM `ModuloVentas`.`tbl_producto` WHERE nombre_producto = '" + nombreProducto[i] + "';";
                OdbcCommand cmdIdProducto = new OdbcCommand(idProducto, conexion.Conexion());
                OdbcDataReader readerIdProducto = cmdIdProducto.ExecuteReader();
                while (readerIdProducto.Read())
                {
                    string idProductoDetalle = readerIdProducto.GetString(0);
                    txt_id_producto.Text = idProductoDetalle;
                }

                string detalleCotizacion = "insert into `ModuloVentas`.`tbl_detalle_cotizacion` values (" + txt_id_detalle_cotizacion.Text + "," + txt_id.Text + "," + txt_id_producto.Text + "," + txt_precio_detalle.Text + ", " + txt_cantidad_detalle.Text + "," + txt_total_detalle.Text + "," + txt_estado.Text + ");";
                OdbcCommand cmdInsertarDetalle = new OdbcCommand(detalleCotizacion, conexion.Conexion());
                cmdInsertarDetalle.ExecuteNonQuery();

                int idActualDetalle = int.Parse(txt_id_detalle_cotizacion.Text);
                idActualDetalle = idActualDetalle + 1;
                txt_id_detalle_cotizacion.Text = idActualDetalle.ToString();
            }

            MessageBox.Show("Dato Insertado");
            dataGridView1.Rows.Clear();
            int idActual = int.Parse(txt_id.Text);
            idActual = idActual + 1;
            txt_id.Text = idActual.ToString();
            actualizarGrid();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la fila seleccionada es válida
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView2.Rows[e.RowIndex];

                // Obtener los valores de las celdas de la fila seleccionada
                string valorColumna1 = filaSeleccionada.Cells[0].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells[1].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells[2].Value.ToString();
                string valorColumna4 = filaSeleccionada.Cells[3].Value.ToString();
                // Asignar los valores a los TextBox correspondientes
                txt_id_consulta.Text = valorColumna1;
                string idAlmacen = "SELECT nombre_almacen FROM `ModuloVentas`.`tbl_almacen` WHERE codigo_almacen = " + valorColumna2 + ";";
                OdbcCommand cmdAlmacen = new OdbcCommand(idAlmacen, conexion.Conexion());
                OdbcDataReader readerAlmacen = cmdAlmacen.ExecuteReader();
                while (readerAlmacen.Read())
                {
                    string nombreAlmacen = readerAlmacen.GetString(0);
                    txt_almacen_consulta.Text = nombreAlmacen;
                }
                string idCliente = "SELECT Dpi_clientes FROM `ModuloVentas`.`tbl_clientes` WHERE Pk_idClientes = " + valorColumna3 + ";";
                OdbcCommand cmdCliente = new OdbcCommand(idCliente, conexion.Conexion());
                OdbcDataReader readerCliente = cmdCliente.ExecuteReader();
                while (readerCliente.Read())
                {
                    string dpiCliente = readerCliente.GetString(0);
                    txt_cliente_consulta.Text = dpiCliente;
                }
                txt_fecha_consulta.Text = valorColumna4;
                string idEstado = "SELECT Pk_estado_cotizacion FROM moduloventas.tbl_detalle_cotizacion where Pk_idCotizacion = " + valorColumna1 + ";";
                OdbcCommand cmdEstado = new OdbcCommand(idEstado, conexion.Conexion());
                OdbcDataReader readerEstado = cmdEstado.ExecuteReader();
                while (readerEstado.Read())
                {
                    string idEstadoConsulta = readerEstado.GetString(0);
                    txt_estado_consulta.Text = idEstadoConsulta;
                }
                string nombreEstado = "SELECT descripcion_estado_cotizacion FROM moduloventas.tbl_estado_cotizacion where Pk_estado_cotizacion = " + txt_estado_consulta.Text + ";";
                OdbcCommand cmdEstadoConsulta = new OdbcCommand(nombreEstado, conexion.Conexion());
                OdbcDataReader readerEstadoConsulta = cmdEstadoConsulta.ExecuteReader();
                while (readerEstadoConsulta.Read())
                {
                    string nombreEstadoConsulta = readerEstadoConsulta.GetString(0);
                    txt_estado_consulta.Text = nombreEstadoConsulta;
                }

                dataGridView3.Rows.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string idProducto = "SELECT  `a`.`nombre_producto` FROM (`moduloventas`.`tbl_detalle_cotizacion` `b` JOIN `moduloventas`.`tbl_producto` `a` ON ((`a`.`codigo_producto` = `b`.`codigo_producto`)) AND  ((`b`.`Pk_idCotizacion` =" + txt_id_consulta.Text + ")));";
            List<string> arregloProducto = new List<string>();
            List<string> arregloCantidad = new List<string>();
            List<string> arregloPrecio = new List<string>();
            List<string> arregloTotal = new List<string>();

            OdbcCommand cmdProducto = new OdbcCommand(idProducto, conexion.Conexion());
            OdbcDataReader readerProducto = cmdProducto.ExecuteReader();
            int cont = 0;
            while (readerProducto.Read())
            {
                arregloProducto.Add(readerProducto.GetString(0));
                cont = cont + 1;
            }
            string idCantidad = "SELECT  `b`.`Cantidad_detallecotizacion`FROM (`moduloventas`.`tbl_detalle_cotizacion` `b` JOIN `moduloventas`.`tbl_producto` `a` ON ((`a`.`codigo_producto` = `b`.`codigo_producto`)) AND  ((`b`.`Pk_idCotizacion` =" + txt_id_consulta.Text + ")));";
            OdbcCommand cmdCantidad = new OdbcCommand(idCantidad, conexion.Conexion());
            OdbcDataReader readerCantidad = cmdCantidad.ExecuteReader();

            while (readerCantidad.Read())
            {
                arregloCantidad.Add(readerCantidad.GetString(0));
            }
            string idPrecio = "SELECT  `b`.`precio_unitario_producto` FROM (`moduloventas`.`tbl_detalle_cotizacion` `b` JOIN `moduloventas`.`tbl_producto` `a` ON ((`a`.`codigo_producto` = `b`.`codigo_producto`)) AND  ((`b`.`Pk_idCotizacion` = " + txt_id_consulta.Text + ")));";
            OdbcCommand cmdPrecio = new OdbcCommand(idPrecio, conexion.Conexion());
            OdbcDataReader readerPrecio = cmdPrecio.ExecuteReader();

            while (readerPrecio.Read())
            {
                arregloPrecio.Add(readerPrecio.GetString(0));
            }
            string idTotal = "SELECT  `b`.`Total_detalle_detallecotizacion` FROM (`moduloventas`.`tbl_detalle_cotizacion` `b` JOIN `moduloventas`.`tbl_producto` `a` ON ((`a`.`codigo_producto` = `b`.`codigo_producto`)) AND  ((`b`.`Pk_idCotizacion` = " + txt_id_consulta.Text + ")));";
            OdbcCommand cmdTotal = new OdbcCommand(idTotal, conexion.Conexion());
            OdbcDataReader readerTotal = cmdTotal.ExecuteReader();

            while (readerTotal.Read())
            {
                arregloTotal.Add(readerTotal.GetString(0));
            }
            for (int i = 0; i < cont; i++)
            {
                dataGridView3.Rows.Add(arregloProducto[i], arregloCantidad[i], arregloPrecio[i], arregloTotal[i]);
            }
        }
    }
}
