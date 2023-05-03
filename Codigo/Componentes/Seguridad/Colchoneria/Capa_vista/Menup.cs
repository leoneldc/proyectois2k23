﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;
//Comentado por George Mayén 25/02/2023
namespace Vista_Seguridad
{
    public partial class Menup : Form
    {
        Controlador cn = new Controlador();

        //Método que guarda en un arreglo de tipo botón los botones que se tienen en el formulario. Se les da permiso a los diferentes botones de acuerdo a la función que realice este
        public Menup()
        {
            InitializeComponent();

            Button[] apps = { btnseguridad, btlogistica, btncompras, btnProduccion, btnnominas, btnBancos, btnContabilidad};
            cn.deshabilitarApps(apps);

            cn.getAccesoApp(1000, apps[0]);
            cn.getAccesoApp(2000, apps[1]);
            cn.getAccesoApp(3000, apps[2]);
            cn.getAccesoApp(5000, apps[3]);
            cn.getAccesoApp(6000, apps[4]);
            cn.getAccesoApp(7000, apps[5]);
            cn.getAccesoApp(8000, apps[6]);
           

        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        public void btnlogout_Click(object sender, EventArgs e)
        {
            MenuSeguridad b = new MenuSeguridad();
            b.Show();
            cn.setBtitacora("1000", "Ingreso Seguridad");
            //this.Close();
        }

        public void btlogistica_Click(object sender, EventArgs e)
        {
            /*VistaLogistica.Menu b = new VistaLogistica.Menu();
              b.Show();
            cn.setBtitacora("2000", "Ingreso Logistica");*/
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Login b = new Login();
            cn.setBtitacora("999", "Cerro Sesion");
            b.Show();
            this.Close();
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btncompras_Click(object sender, EventArgs e)
        {
            /*ComprasVista.central_Compra b = new ComprasVista.central_Compra();
            b.Show();*/
            cn.setBtitacora("3000", "Ingreso Compras");
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btnProduccion_Click(object sender, EventArgs e)
        {
            /*CapaVistaProduccion.inicio b = new CapaVistaProduccion.inicio();
           b.Show();*/
            cn.setBtitacora("5000", "Ingreso Produccion");
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btnnominas_Click(object sender, EventArgs e)
        {
            /*
            CPC_Vista.CPC_MDI formCpc = new CPC_Vista.CPC_MDI();
            formCpc.Show();
            cn.setBtitacora("6000", "Ingreso Cuentas por Cobrar");
            */
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btnBancos_Click(object sender, EventArgs e)
        {
           /*Vista_Bancos.Banco_Form b = new Vista_Bancos.Banco_Form();
           b.Show();*/
           cn.setBtitacora("7000", "Ingreso Bancos");
        }

        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btnContabilidad_Click(object sender, EventArgs e)
        {
           /*Capa_VistaContabilidad.Nuevo_MDI b = new Capa_VistaContabilidad.Nuevo_MDI();
           b.Show();*/
            cn.setBtitacora("8000", "Ingreso Contabilidad");
        }
    }
}
