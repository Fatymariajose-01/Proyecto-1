using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    internal class Vehiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Tipo { get; set; }
        public string HoraEntrada { get; set; }

        public Vehiculo(string placa, string marca, string modelo, string color, string tipo, string horaentrada)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Tipo = tipo;
            HoraEntrada = horaentrada;
        }
    }

}
