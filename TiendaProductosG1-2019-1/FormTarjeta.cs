using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaProductosG1_2019_1
{
    public partial class FormTarjeta : Form
    {

        #region Atributos  de Tarjeta
        private string numtarjeta;
        private string cvv;
        private string fecha;
        private float saldo;
        private float comision;
        private float totalPagar;
        private Form1 formPadre;
        #endregion
        #region Propiedades de Tarjeta
        public string Numtarjeta { get => numtarjeta; set => numtarjeta = value; }
        public string Cvv { get => cvv; set => cvv = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public float Comision { get => comision; set => comision = value; }
        public float TotalPagar { get => totalPagar; set => totalPagar = value; }
        #endregion


        public FormTarjeta(Form1 formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            TotalPagar = formPadre.TotalPagar;
            Comision = 1.10f;
            TotalPagar = Comision * TotalPagar;
            lbTotalPagar.Text = (TotalPagar).ToString();
        }

        private void btnTotalPagar_Click(object sender, EventArgs e)
        {
            Numtarjeta = mskNumeroTarjeta.Text;
            Cvv = mskCVV.Text;
            Fecha = mskFechaVencimiento.Text;
            Random SaldoAleatorio = new Random();
            Saldo = (float)(SaldoAleatorio.NextDouble()*1000);
            
            this.Close();
            
        }
    }
}
