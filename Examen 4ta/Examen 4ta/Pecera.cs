using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4ta
{
    class Pecera
    {
        private double galones = 0;
        private double litros = 0;

        public void CalculoLitros(double largo, double ancho, double alto)
        {
            litros = largo * ancho * largo;
        }

        public double VerLitros()
        {
            return litros;
        }

        public double CalculoGalones()
        {

        }
    }
}
    }
}
