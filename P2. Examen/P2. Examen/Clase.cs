using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Examen
{
    class Clase
    {
        public void Play()
        {
            int[] Array = new int[80]; //Creamos el Array.
            Random random = new Random(); //Instanciamos un objeto de la clase Random.
            for (int i = 0; i < 80; i++)
            {
                if (i > 0) //Mientras sea mayor a 0.
                {
                    for (int x = 0; x < 100; x++) //Comprobara por 100 veces para mayor presición
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (Array[i] == Array[j]) //Compara con el segundo número que se genera para que no se repita.
                            {
                                Array[i] = random.Next(0, 80); //Asignamos un número aleatorio entre 0 y 80.
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < 80; i++)
            {
                Console.WriteLine("Posición[{0}]: {1}", i, Array[i]); //Impresion del vector aleatorio desordenado.
            }
            Console.Write("\nPresione enter.");
            Console.ReadKey();
            Console.Clear();
            Proceso obj = new Proceso();
            obj.Radix(Array); //Llamamos a ejecutar al método Radix con el Array como parámetro.
            int k = 0;
            foreach (var item in Array)
            {
                Console.WriteLine("Posición[{0}]: {1}", k, item); //Impresion del vector aleatorio desordenado.
                k++;
            }
            Console.Write("\nPresione enter.");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
