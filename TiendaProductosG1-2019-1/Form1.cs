﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaProductosG1_2019_1
{
    public partial class Form1 : Form
    {
        Producto miProducto;
        ArrayList colProductos;


        

        public Form1()
        {
            InitializeComponent();
            colProductos = new ArrayList();
            colProductos.Add(new Producto("Refresco", 10.50f, 200, "7677625567",0));
            colProductos.Add(new Producto("Papitas", 11, 100, "673562352626", 0));
            colProductos.Add(new Producto("Dulces de tamarindo", 6.5f, 150, "73526352626", 0));
           

            for (int i = 0; i < colProductos.Count; i++)
            {
                miProducto = (Producto)colProductos[i];
                cmbProducto.Items.Add(miProducto.Nombre);
            }

                
        }

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txbPrecioUnitario.Text = 
        }
    }
}
