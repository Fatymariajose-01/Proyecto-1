using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    internal class PagoConTarjeta
    {
        public string  numeroTarjeta { get; set; }
        public string nombreTitular { get; set; }
        public string fechaVencimiento { get; set; }
        public string CVV { get; set; }

        public PagoConTarjeta(string numerotarjeta, string nombretitular, string fechavencimiento, string cvv)
        {
            numeroTarjeta = numerotarjeta;
            nombreTitular = nombretitular;
            fechaVencimiento = fechavencimiento;
            CVV = cvv;
        }
    }
}
