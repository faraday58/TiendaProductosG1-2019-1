using System;
using System.Collections;
using System.Drawing;
using InterfazPago;
using System.Windows.Forms;

namespace TiendaProductosG1_2019_1
{

    public partial class Form1 : Form,Ipago

    {
        #region Atributos


        Producto miProducto;
        ArrayList colProductos;
        #endregion
        #region Constructores
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
        #endregion
        #region Eventos
        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            miProducto =(Producto) colProductos[cmbProducto.SelectedIndex];
            txbPrecioUnitario.Text =miProducto.Precio.ToString();
            txbNombre.Text = miProducto.Nombre.ToString();
            txbProductosExistentes.Text = miProducto.Stock.ToString();
            txbClave.Text = miProducto.Clave;

        }
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbEfectivo.Checked = true;
            txtbEfectivo.Visible = true;
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)Keys.Enter  )
            {
                miProducto.Cantidad = int.Parse(textBox1.Text);
                txbPrecioTotal.Text = (miProducto.Cantidad * miProducto.Precio).ToString();
            }
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(rdbEfectivo.Checked)
            {
                MessageBox.Show("$"+PEfectivo(float.Parse(txbPrecioTotal.Text), float.Parse(txtbEfectivo.Text)).ToString(), "Cambio");
            }
            else if (rdbTarjeta.Checked)
            {
                MessageBox.Show("$" + PTarjeta(float.Parse(txbPrecioTotal.Text),"0", float.Parse(txtbEfectivo.Text),0,0).ToString(), "Saldo");
            }
        }

        #endregion
        #region Metodos de Interfaz
        public float PEfectivo(float preciototal, float efectivo)
        {
            float cambio=0;
            try
            {
                if (preciototal > efectivo)
                {
                    throw new ApplicationException("Eres pobre no te alcanza, ese Benito es de los antiguos");
                }
                else
                {
                    errorProv.Clear();
                    cambio = efectivo - preciototal;
                }
            }
            catch(ApplicationException error)
            {
                errorProv.SetError(txtbEfectivo, error.Message);
                cambio = -1;
            }
            return cambio;
        }

        public float PTarjeta(float preciototal, string numtarjeta, float saldo, ushort pin, float comision)
        {
            try
            {
                if (saldo < preciototal)
                {
                    throw new ApplicationException("Saldo insuficiente");
                }
                else
                {
                    saldo = saldo - preciototal;
                }
            }
            catch (ApplicationException e)
            {
                errorProv.SetError(txtbEfectivo, e.Message);
                
            }
            return saldo;

        }

        #endregion

        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            rdbEfectivo.Checked = false;
            txtbEfectivo.Visible = false;
        }

        private void rdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
