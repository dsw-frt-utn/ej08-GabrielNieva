using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string ComprarCopias(int originalValue, Product product) 
        {
            int copiaValor = originalValue;
            copiaValor++;
            Product copiaProducto = product;
            copiaProducto.ModificarDescripcion("Producto Modificado");
            return $"{originalValue}-{copiaValor}-{product.Descripcion}";
        }
    }
}
