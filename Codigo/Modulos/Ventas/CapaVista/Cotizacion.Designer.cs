
namespace CapaVista
{
    partial class Cotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txt_total_detalle = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_id_detalle_cotizacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_codigo_producto = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_precio_unitario = new System.Windows.Forms.TextBox();
            this.txt_id_cotizacion = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_detalle_venta = new System.Windows.Forms.TextBox();
            this.txt_clientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_almacen_encabezado = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cotización";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(217, 70);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(768, 190);
            this.navegador1.TabIndex = 8;
            // 
            // txt_total_detalle
            // 
            this.txt_total_detalle.Location = new System.Drawing.Point(1139, 374);
            this.txt_total_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total_detalle.Name = "txt_total_detalle";
            this.txt_total_detalle.Size = new System.Drawing.Size(194, 22);
            this.txt_total_detalle.TabIndex = 36;
            this.txt_total_detalle.Tag = "tbl_detalle_Cotizacion,Total_detalle_detallecotizacion";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(513, 418);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 20);
            this.label23.TabIndex = 35;
            this.label23.Text = "Estado";
            // 
            // txt_id_detalle_cotizacion
            // 
            this.txt_id_detalle_cotizacion.Location = new System.Drawing.Point(742, 285);
            this.txt_id_detalle_cotizacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_detalle_cotizacion.Name = "txt_id_detalle_cotizacion";
            this.txt_id_detalle_cotizacion.Size = new System.Drawing.Size(194, 22);
            this.txt_id_detalle_cotizacion.TabIndex = 34;
            this.txt_id_detalle_cotizacion.Tag = "tbl_detalle_Cotizacion,Pk_detallecotizacion,primary";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(513, 289);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 20);
            this.label16.TabIndex = 33;
            this.label16.Tag = "Pk_idVendedores";
            this.label16.Text = "Id Detalle cotización";
            // 
            // btn_modificar
            // 
            this.btn_modificar.ForeColor = System.Drawing.Color.Black;
            this.btn_modificar.Location = new System.Drawing.Point(1056, 459);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(129, 26);
            this.btn_modificar.TabIndex = 27;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(1191, 459);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(129, 26);
            this.btn_eliminar.TabIndex = 28;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_codigo_producto
            // 
            this.txt_codigo_producto.Location = new System.Drawing.Point(742, 330);
            this.txt_codigo_producto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo_producto.Name = "txt_codigo_producto";
            this.txt_codigo_producto.Size = new System.Drawing.Size(194, 22);
            this.txt_codigo_producto.TabIndex = 32;
            this.txt_codigo_producto.Tag = "tbl_detalle_Cotizacion,Fk_idproduc_detallecotizacion";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(742, 414);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(194, 22);
            this.txt_estado.TabIndex = 31;
            this.txt_estado.Tag = "tbl_detalle_Cotizacion,Estado_detallecotizacion";
            // 
            // btn_guardar
            // 
            this.btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar.Location = new System.Drawing.Point(921, 459);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(129, 26);
            this.btn_guardar.TabIndex = 26;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(978, 326);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "Cantidad";
            // 
            // txt_precio_unitario
            // 
            this.txt_precio_unitario.Location = new System.Drawing.Point(742, 372);
            this.txt_precio_unitario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio_unitario.Name = "txt_precio_unitario";
            this.txt_precio_unitario.Size = new System.Drawing.Size(194, 22);
            this.txt_precio_unitario.TabIndex = 28;
            this.txt_precio_unitario.Tag = "tbl_detalle_Cotizacion,Precio_uni_detallecotizacion";
            // 
            // txt_id_cotizacion
            // 
            this.txt_id_cotizacion.Location = new System.Drawing.Point(1139, 285);
            this.txt_id_cotizacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_cotizacion.Name = "txt_id_cotizacion";
            this.txt_id_cotizacion.Size = new System.Drawing.Size(194, 22);
            this.txt_id_cotizacion.TabIndex = 27;
            this.txt_id_cotizacion.Tag = "tbl_detalle_Cotizacion,Pk_idCotizacion";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(1139, 326);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(194, 22);
            this.txt_cantidad.TabIndex = 25;
            this.txt_cantidad.Tag = "tbl_detalle_Cotizacion,Cantidad_detallecotizacion";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(513, 376);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 20);
            this.label19.TabIndex = 24;
            this.label19.Text = "Precio unitario";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(944, 285);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 20);
            this.label20.TabIndex = 23;
            this.label20.Text = "Id Cotización";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(1007, 374);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 20);
            this.label21.TabIndex = 22;
            this.label21.Text = "Total";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(513, 330);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 20);
            this.label22.TabIndex = 21;
            this.label22.Text = "Codigo producto";
            // 
            // txt_detalle_venta
            // 
            this.txt_detalle_venta.Location = new System.Drawing.Point(267, 420);
            this.txt_detalle_venta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_detalle_venta.Name = "txt_detalle_venta";
            this.txt_detalle_venta.Size = new System.Drawing.Size(194, 22);
            this.txt_detalle_venta.TabIndex = 41;
            this.txt_detalle_venta.Tag = "tbl_cotizacion,Fk_detalleVenta_cotizacion";
            // 
            // txt_clientes
            // 
            this.txt_clientes.Location = new System.Drawing.Point(267, 376);
            this.txt_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_clientes.Name = "txt_clientes";
            this.txt_clientes.Size = new System.Drawing.Size(194, 22);
            this.txt_clientes.TabIndex = 40;
            this.txt_clientes.Tag = "tbl_cotizacion,Pk_idClientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Id detalle venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 378);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id Clientes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(58, 291);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Id";
            // 
            // txt_almacen_encabezado
            // 
            this.txt_almacen_encabezado.Location = new System.Drawing.Point(267, 330);
            this.txt_almacen_encabezado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_almacen_encabezado.Name = "txt_almacen_encabezado";
            this.txt_almacen_encabezado.Size = new System.Drawing.Size(194, 22);
            this.txt_almacen_encabezado.TabIndex = 26;
            this.txt_almacen_encabezado.Tag = "tbl_cotizacion,codigo_almacen";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(267, 291);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(194, 22);
            this.txt_id.TabIndex = 25;
            this.txt_id.Tag = "tbl_cotizacion,Pk_idCotizacion,primary";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(58, 330);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Almacen";
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1366, 525);
            this.Controls.Add(this.txt_total_detalle);
            this.Controls.Add(this.txt_detalle_venta);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txt_clientes);
            this.Controls.Add(this.txt_id_detalle_cotizacion);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_codigo_producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_precio_unitario);
            this.Controls.Add(this.txt_almacen_encabezado);
            this.Controls.Add(this.txt_id_cotizacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_total_detalle;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_id_detalle_cotizacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_codigo_producto;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_precio_unitario;
        private System.Windows.Forms.TextBox txt_id_cotizacion;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_detalle_venta;
        private System.Windows.Forms.TextBox txt_clientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_almacen_encabezado;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label12;
    }
}