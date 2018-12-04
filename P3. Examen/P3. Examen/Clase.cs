using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3.Examen
{
    class Clase
    {
        public void Play()
        {
            Console.Write("¿Cuántos elementos desea introducir?: ");
            int cant = int.Parse(Console.ReadLine());
            int[] Array = new int[cant]; //Creamos un Array.
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Ingrese el elemento {0}: ", i + 1); //Capturamos valores de cada elemento.
                Array[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Vector desordenado: "); //Desplegamos el vector sin alteraciones.
            foreach (var item in Array)
            {
                Console.Write(" {0} ;", item);
            }
            Proceso obj = new Proceso();
            obj.Shell(Array); //Ordenamos el vector.
            Console.WriteLine("\n-  -   -   -   -   -   -   -   -\nVector ordenado en forma descendente: ");
            for (int i = Array.Length - 1; i >= 0; i--) //De esta manera se imprime de mayor a menor.
            {
                Console.Write(" {0} ;", Array[i]); //Desplegamos el vector alterado.
            }
            Console.ReadKey();
        }
    }
}
