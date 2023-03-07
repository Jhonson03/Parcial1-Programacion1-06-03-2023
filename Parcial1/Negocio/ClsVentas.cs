using Parcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Negocio
{
    public class ClsVentas
    {
        public String Cobro(Venta ven)
        {
            double ApliDesc = ven.PreProducto * ven.CantidadProducto;

            if (ApliDesc > 50)
            {
                ven.NuevoDescue = ApliDesc - 10;
                return $"Se ha aplicado el descuento de $10 por su compra mayor de $50 el total es ${ven.NuevoDescue}";
            }
            else
            {
                return $"No aplica descuento total a pagar ${ApliDesc}";
            }
        }
    }
}
