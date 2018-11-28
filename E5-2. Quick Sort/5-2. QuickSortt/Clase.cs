using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2.QuickSortt
{
    class Clase
    {
        public void Play()
        {            
            double[] ArrayA = new double[] { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 }; //Creamos el vector con los valores que tendrá cada elemento.
            Console.WriteLine("1.- Vector sin alterar:");
            foreach (var item in ArrayA) //Imprimimos los elementos del vector que aún no recibe cambios.
            {
                Console.Write(" {0} ;", item);
            }
            Proceso A = new Proceso(ArrayA); //Se crea un objeto y mandamos como párametro el vector y ejecuta toda la clase Proceso.
            //
            double[] ArrayB = new double[] { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0, 10 };
            Console.WriteLine("2.- Vector sin alterar:");
            foreach (var item in ArrayB)
            {
                Console.Write(" {0} ;", item);
            }
            Proceso B = new Proceso(ArrayB);
            //
            double[] ArrayC = new double[] { 3, 7, 15, 1.33, 155, 100, 15, 1.73, 5, 2, 3, 2 };
            Console.WriteLine("3.- Vector sin alterar:");
            foreach (var item in ArrayC)
            {
                Console.Write(" {0} ;", item);
            }
            Proceso C = new Proceso(ArrayC);
            //
            double[] ArrayD = new double[] { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };
            Console.WriteLine("4.- Vector sin alterar:");
            foreach (var item in ArrayD)
            {
                Console.Write(" {0} ;", item);
            }
            Proceso D = new Proceso(ArrayC);
            Console.WriteLine("Salir.");
            Console.ReadKey();
        }
    }
}
