using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Color = "Amarillo";
            Console.WriteLine(triangulo.toString());
            triangulo.Altura = 2.5;
            triangulo.Base = 4;

            double areaTriangulo = triangulo.getArea();
            Console.WriteLine("Area de triangulo: " + areaTriangulo);

            Circulo circulo = new Circulo(5.4);
            /*circulo.Color = "Rojo";
            Console.WriteLine(circulo.toString());*/

            Console.WriteLine("Area del circulo: " + circulo.getArea().ToString());

            Figura triangulo2 = new Triangulo();
            ((Triangulo)triangulo2).Base = 2;
            ((Triangulo)triangulo2).Altura = 3;

            Console.WriteLine("Area de triangulo 2: " + triangulo2.getArea().ToString());

            List<Figura> figuras = new List<Figura>();
            figuras.Add(triangulo);
            figuras.Add(circulo);
            figuras.Add(triangulo2);

            foreach(var figura in figuras)
            {
                Console.WriteLine("Area: " + figura.getArea().ToString());
            }

            Console.Read();

        }
    }
}
