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
        public double Cobro(Venta ven)
        {
            double ApliDesc = ven.PreProducto * ven.CantidadProducto;

            if (ApliDesc > 50)
            {
                ven.NuevoDescue = ApliDesc / 90;
                return ven.NuevoDescue;
            }
            else
            {
                return ApliDesc;
            }
        }
    }
}
