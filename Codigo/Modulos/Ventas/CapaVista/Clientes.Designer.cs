
namespace CapaVista
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.barratitulo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.navegador1 = new NavegadorVista.Navegador();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_abonosacum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_cargosacum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_abonomes = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cargomes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_saldoactual = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_smesanterior = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_fechanac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barratitulo
            // 
            this.barratitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.barratitulo.Controls.Add(this.button1);
            this.barratitulo.Controls.Add(this.navegador1);
            this.barratitulo.Controls.Add(this.dataGridView1);
            this.barratitulo.Controls.Add(this.panel1);
            this.barratitulo.Controls.Add(this.label1);
            this.barratitulo.Location = new System.Drawing.Point(16, 12);
            this.barratitulo.Margin = new System.Windows.Forms.Padding(4);
            this.barratitulo.Name = "barratitulo";
            this.barratitulo.Size = new System.Drawing.Size(1740, 817);
            this.barratitulo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(56, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 85);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(479, 63);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(768, 190);
            this.navegador1.TabIndex = 3;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 527);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1696, 272);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Tag = "tbl_clientes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_abonosacum);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txt_cargosacum);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txt_abonomes);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_cargomes);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txt_saldoactual);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_smesanterior);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_estado);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_vendedor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_telefono);
            this.panel1.Controls.Add(this.txt_dpi);
            this.panel1.Controls.Add(this.txt_apellido);
            this.panel1.Controls.Add(this.txt_fechanac);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_nit);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(29, 262);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1696, 241);
            this.panel1.TabIndex = 1;
            // 
            // txt_abonosacum
            // 
            this.txt_abonosacum.Location = new System.Drawing.Point(1452, 192);
            this.txt_abonosacum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_abonosacum.Name = "txt_abonosacum";
            this.txt_abonosacum.Size = new System.Drawing.Size(207, 22);
            this.txt_abonosacum.TabIndex = 33;
            this.txt_abonosacum.Tag = "AbonosAcumulados_clientes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1263, 190);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Abonos acumulados";
            // 
            // txt_cargosacum
            // 
            this.txt_cargosacum.Location = new System.Drawing.Point(1452, 140);
            this.txt_cargosacum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cargosacum.Name = "txt_cargosacum";
            this.txt_cargosacum.Size = new System.Drawing.Size(207, 22);
            this.txt_cargosacum.TabIndex = 31;
            this.txt_cargosacum.Tag = "CargosAcumulados_clientes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1263, 140);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "Cargos acumulados";
            // 
            // txt_abonomes
            // 
            this.txt_abonomes.Location = new System.Drawing.Point(1452, 91);
            this.txt_abonomes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_abonomes.Name = "txt_abonomes";
            this.txt_abonomes.Size = new System.Drawing.Size(207, 22);
            this.txt_abonomes.TabIndex = 29;
            this.txt_abonomes.Tag = "AbonosMes_clientes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1263, 89);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Abono del mes";
            // 
            // txt_cargomes
            // 
            this.txt_cargomes.Location = new System.Drawing.Point(1452, 39);
            this.txt_cargomes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cargomes.Name = "txt_cargomes";
            this.txt_cargomes.Size = new System.Drawing.Size(207, 22);
            this.txt_cargomes.TabIndex = 27;
            this.txt_cargomes.Tag = "CargoMes_clientes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1263, 39);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Cargo del mes";
            // 
            // txt_saldoactual
            // 
            this.txt_saldoactual.Location = new System.Drawing.Point(1020, 187);
            this.txt_saldoactual.Margin = new System.Windows.Forms.Padding(4);
            this.txt_saldoactual.Name = "txt_saldoactual";
            this.txt_saldoactual.Size = new System.Drawing.Size(207, 22);
            this.txt_saldoactual.TabIndex = 25;
            this.txt_saldoactual.Tag = "SActual_clientes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(831, 185);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Saldo actual";
            // 
            // txt_smesanterior
            // 
            this.txt_smesanterior.Location = new System.Drawing.Point(1020, 135);
            this.txt_smesanterior.Margin = new System.Windows.Forms.Padding(4);
            this.txt_smesanterior.Name = "txt_smesanterior";
            this.txt_smesanterior.Size = new System.Drawing.Size(207, 22);
            this.txt_smesanterior.TabIndex = 23;
            this.txt_smesanterior.Tag = "SMesAnterior_clientes";
            this.txt_smesanterior.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(831, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Saldo mes anterior";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(571, 185);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(219, 22);
            this.txt_direccion.TabIndex = 21;
            this.txt_direccion.Tag = "direccion_clientes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(381, 182);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Direccion ";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(571, 133);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(219, 22);
            this.txt_estado.TabIndex = 19;
            this.txt_estado.Tag = "estado_clientes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(381, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Estado";
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.Location = new System.Drawing.Point(1020, 86);
            this.txt_vendedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.Size = new System.Drawing.Size(207, 22);
            this.txt_vendedor.TabIndex = 17;
            this.txt_vendedor.Tag = "fk_idvendedor_clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(831, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID Vendedor";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(1020, 34);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(207, 22);
            this.txt_telefono.TabIndex = 15;
            this.txt_telefono.Tag = "telefono_clientes";
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(133, 79);
            this.txt_dpi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(211, 22);
            this.txt_dpi.TabIndex = 14;
            this.txt_dpi.Tag = "Dpi_clientes";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(131, 181);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(213, 22);
            this.txt_apellido.TabIndex = 13;
            this.txt_apellido.Tag = "Apellidos_clientes";
            // 
            // txt_fechanac
            // 
            this.txt_fechanac.Location = new System.Drawing.Point(571, 32);
            this.txt_fechanac.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fechanac.Name = "txt_fechanac";
            this.txt_fechanac.Size = new System.Drawing.Size(219, 22);
            this.txt_fechanac.TabIndex = 12;
            this.txt_fechanac.Tag = "FechaNac_clientes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(831, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(381, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "DPI";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(571, 81);
            this.txt_nit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(220, 22);
            this.txt_nit.TabIndex = 7;
            this.txt_nit.Tag = "nit_clientes";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(133, 133);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(211, 22);
            this.txt_nombre.TabIndex = 5;
            this.txt_nombre.Tag = "Nombres_clientes";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(131, 31);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(213, 22);
            this.txt_id.TabIndex = 4;
            this.txt_id.Tag = "Pk_idClientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(381, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "NIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(765, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 844);
            this.Controls.Add(this.barratitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.barratitulo.ResumeLayout(false);
            this.barratitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barratitulo;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_fechanac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_vendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_abonosacum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_cargosacum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_abonomes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_cargomes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_saldoactual;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_smesanterior;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}