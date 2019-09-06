using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class Figura
    {
        public string Color { get; set; }
        //Todas las figuras debe de poder calcular su área
        public abstract double getArea();
        public string toString()
        {
            return "Soy una figura: " + Color;
        }
    }
}
