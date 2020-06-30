using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ing_SW_B
{
    class CDetalleVenta
    {
        public int folio;
        public int idProducto;
        public int cantidad;
        public float precioU;
        public float subtotal;
        
        public CDetalleVenta()
        {
            folio = 0;
            idProducto = 0;
            cantidad = 0;
            precioU = 0;
            subtotal = 0;
        }
    }
}
