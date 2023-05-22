
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
            this.panel1 = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
=======
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_idCotizacion = new System.Windows.Forms.TextBox();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_CodigoProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            this.txt_sucursal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_detalleventa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_idcliente = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
<<<<<<< HEAD
=======
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.navegador1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
<<<<<<< HEAD
            this.panel1.Size = new System.Drawing.Size(911, 734);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 404);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(856, 306);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.Tag = "tbl_cotizacion";
            // 
            // txt_sucursal
            // 
            this.txt_sucursal.Location = new System.Drawing.Point(215, 348);
            this.txt_sucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sucursal.Name = "txt_sucursal";
            this.txt_sucursal.Size = new System.Drawing.Size(237, 22);
            this.txt_sucursal.TabIndex = 22;
=======
            this.panel1.Size = new System.Drawing.Size(1001, 596);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.txt_Cantidad);
            this.groupBox2.Controls.Add(this.btn_modificar);
            this.groupBox2.Controls.Add(this.txt_Precio);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_total);
            this.groupBox2.Controls.Add(this.txt_idCotizacion);
            this.groupBox2.Controls.Add(this.txt_Estado);
            this.groupBox2.Controls.Add(this.txt_CodigoProducto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(399, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 141);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle venta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 34;
            this.textBox1.Tag = "Pk_detallecotizacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 33;
            this.label10.Tag = "Pk_idVendedores";
            this.label10.Text = "Id";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(505, 111);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(67, 21);
            this.btn_eliminar.TabIndex = 28;
            this.btn_eliminar.Text = "eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(142, 112);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(181, 20);
            this.txt_Cantidad.TabIndex = 32;
            this.txt_Cantidad.Tag = "Cantidad_detallecotizacion";
            // 
            // btn_modificar
            // 
            this.btn_modificar.ForeColor = System.Drawing.Color.Black;
            this.btn_modificar.Location = new System.Drawing.Point(421, 111);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(67, 21);
            this.btn_modificar.TabIndex = 27;
            this.btn_modificar.Text = "modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(391, 27);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(181, 20);
            this.txt_Precio.TabIndex = 31;
            this.txt_Precio.Tag = "Precio_uni_detallecotizacion";
            // 
            // btn_guardar
            // 
            this.btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar.Location = new System.Drawing.Point(341, 111);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(67, 21);
            this.btn_guardar.TabIndex = 26;
            this.btn_guardar.Text = "guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(338, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 29;
            this.label6.Tag = "Pk_idVendedores";
            this.label6.Text = "Precio";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(391, 57);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(181, 20);
            this.txt_total.TabIndex = 28;
            this.txt_total.Tag = "Total_detalle_detallecotizacion";
            // 
            // txt_idCotizacion
            // 
            this.txt_idCotizacion.Location = new System.Drawing.Point(142, 57);
            this.txt_idCotizacion.Name = "txt_idCotizacion";
            this.txt_idCotizacion.Size = new System.Drawing.Size(181, 20);
            this.txt_idCotizacion.TabIndex = 27;
            this.txt_idCotizacion.Tag = "Fk_idcoti_detallecotizacion";
            // 
            // txt_Estado
            // 
            this.txt_Estado.Location = new System.Drawing.Point(391, 86);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(181, 20);
            this.txt_Estado.TabIndex = 26;
            this.txt_Estado.Tag = "Estado_detallecotizacion";
            // 
            // txt_CodigoProducto
            // 
            this.txt_CodigoProducto.Location = new System.Drawing.Point(142, 86);
            this.txt_CodigoProducto.Name = "txt_CodigoProducto";
            this.txt_CodigoProducto.Size = new System.Drawing.Size(181, 20);
            this.txt_CodigoProducto.TabIndex = 25;
            this.txt_CodigoProducto.Tag = "Fk_idproduc_detallecotizacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(338, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "ID de Cotizacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(338, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID de producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sucursal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_detalleventa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_idcliente);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 141);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // txt_sucursal
            // 
            this.txt_sucursal.Location = new System.Drawing.Point(166, 57);
            this.txt_sucursal.Name = "txt_sucursal";
            this.txt_sucursal.Size = new System.Drawing.Size(182, 20);
            this.txt_sucursal.TabIndex = 30;
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            this.txt_sucursal.Tag = "Sucursal_cotizacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(17, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Id";
            // 
            // txt_detalleventa
            // 
<<<<<<< HEAD
            this.txt_detalleventa.Location = new System.Drawing.Point(643, 347);
            this.txt_detalleventa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_detalleventa.Name = "txt_detalleventa";
            this.txt_detalleventa.Size = new System.Drawing.Size(240, 22);
            this.txt_detalleventa.TabIndex = 21;
=======
            this.txt_detalleventa.Location = new System.Drawing.Point(166, 86);
            this.txt_detalleventa.Name = "txt_detalleventa";
            this.txt_detalleventa.Size = new System.Drawing.Size(182, 20);
            this.txt_detalleventa.TabIndex = 29;
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            this.txt_detalleventa.Tag = "Fk_detalleVenta_cotizacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.label7.Location = new System.Drawing.Point(493, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 20;
=======
            this.label7.Location = new System.Drawing.Point(17, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 28;
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            this.label7.Text = "detalle de venta";
            // 
            // label9
            // 
<<<<<<< HEAD
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sucursal cotización";
            // 
            // txt_idcliente
            // 
            this.txt_idcliente.Location = new System.Drawing.Point(643, 304);
            this.txt_idcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idcliente.Name = "txt_idcliente";
            this.txt_idcliente.Size = new System.Drawing.Size(237, 22);
            this.txt_idcliente.TabIndex = 18;
=======
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Almacen";
            // 
            // txt_idcliente
            // 
            this.txt_idcliente.Location = new System.Drawing.Point(166, 112);
            this.txt_idcliente.Name = "txt_idcliente";
            this.txt_idcliente.Size = new System.Drawing.Size(182, 20);
            this.txt_idcliente.TabIndex = 26;
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            this.txt_idcliente.Tag = "Fk_Idcliente_cotizacion";
            // 
            // txt_id
            // 
<<<<<<< HEAD
            this.txt_id.Location = new System.Drawing.Point(212, 300);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(240, 22);
            this.txt_id.TabIndex = 17;
=======
            this.txt_id.Location = new System.Drawing.Point(166, 27);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(182, 20);
            this.txt_id.TabIndex = 25;
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            this.txt_id.Tag = "Pk_idCotizacion";
            // 
            // label12
            // 
<<<<<<< HEAD
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Id";
=======
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(17, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "id cliente";
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            // 
            // dataGridView1
            // 
<<<<<<< HEAD
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(493, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "id cliente";
=======
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 211);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.Tag = "tbl_cotizacion";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(363, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label1.Location = new System.Drawing.Point(393, 15);
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cotización";
            // 
            // navegador1
            // 
<<<<<<< HEAD
            this.navegador1.Location = new System.Drawing.Point(75, 81);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
=======
            this.navegador1.Location = new System.Drawing.Point(187, 52);
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(768, 190);
            this.navegador1.TabIndex = 4;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(941, 759);
=======
            this.ClientSize = new System.Drawing.Size(1022, 617);
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_sucursal;
        private System.Windows.Forms.TextBox txt_detalleventa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_idcliente;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_idCotizacion;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_CodigoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
<<<<<<< HEAD
        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
=======
>>>>>>> a1765d21b625239555a7fe43c40a272eb07d3290
    }
}