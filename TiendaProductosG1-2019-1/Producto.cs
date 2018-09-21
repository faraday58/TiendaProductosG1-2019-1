using System;

namespace TiendaProductosG1_2019_1
{
    class Producto
    {
        #region Atributos 
        private string nombre;
        private float precio;
        private int stock;
        private string clave;
        private int cantidad;                            
        #endregion


        #region Propiedades
        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre == "")
                {
                    nombre = "nombreDefault";
                }
                else
                {
                    nombre = value;
                }
            }
        }
        public float Precio
        {
            get => precio;
            set
            {
                if (precio < 0)
                {
                    precio = 1;
                }
                else
                {
                    precio = value;
                }                
            }
        }

        public int Stock
        {
            get => stock;
            set
            {
                if (stock > 0)
                {
                    stock = 1;
                }
                else
                {
                    stock = value;
                }                
            }
        }

        public string Clave
        {
            get => clave;
            set
            {
                if(clave=="")
                {
                    clave = "00000";
                }
                else
                {
                    clave = value;
                }
            }
                
        }
        public int Cantidad
        {
            get => cantidad;
            set
            {
                if (cantidad <= 0)
                {
                    cantidad = 1;
                }
                else
                {
                    cantidad = value;
                }
            }
                
        }
        #endregion

        #region Contructores
        public Producto(string nombre, float precio, int stock, string clave, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Clave = clave;
            Cantidad = cantidad;
        }
        #endregion
    }
}
