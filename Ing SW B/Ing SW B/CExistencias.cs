using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ing_SW_B
{
    class CExistencias
    {
        public long idProducto;
        public string nombre;
        public float precio;
        public int cantidad;
        public long idProveedor;

        public CExistencias()
        {
            idProducto = 0;
            nombre = "";
            precio = 0;
            cantidad = 0;
            idProveedor = 0;
        }
    }
}
