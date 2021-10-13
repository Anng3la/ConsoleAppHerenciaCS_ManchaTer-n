using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHerenciaCS_ManchaTerán
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Punto2D a;
            a = new Punto2D(-2.57, -3.72);
            Console.WriteLine(a.ToString())
            
             Punto2D b;
            b = new Punto2D(5.73, 7.62);
            Console.WriteLine(b.ToString())*/

            Punto3D a;
            a = new Punto3D(6, 9, 6);
            Console.WriteLine(a.ToString());

            Punto3D b;
            b = new Punto3D(5, 3, 8);
            Console.WriteLine(b.ToString());

            double d = a.Distancia(b);
            Console.WriteLine(" La distancia es: " + d);

            Console.ReadKey();

            //Profesor disculpe la tardanza, tuve inconvenientes con mi computadora.//
            //Mi primo me presto su computadora para poder hacer el trabajo y de ahí tuve que instalar todo de nuevo//
            //Espero comprenda mi retraso//
        }
    }
}
