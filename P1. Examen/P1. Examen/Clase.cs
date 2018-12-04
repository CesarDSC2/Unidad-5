using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1.Examen
{
    class Clase
    {
        public void Play()
        {
            
            int temp; //Variable temporal.
            Console.Write("¿Cuántos elementos desea introducir?: ");
            int cant = int.Parse(Console.ReadLine());
            int[] array = new int[cant]; //Creamos un Arreglo.
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Ingrese el elemento {0}: ", i + 1); //Pedimos los elementos al usuario.
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] <= 2)
                {
                    continue;                   
                }
                else
                {
                    Console.WriteLine("{0} no es un valor válido. Intente de nuevo.", array[i]);
                    array[i] = array[i] - array[i]; //De esta manera se elimina la captura actual y vuelve a intentar hasta recibir un valor válido.                    
                    i--;
                }
            }
            Console.WriteLine("-    -   -   -   -   -   -   -   \nEl arreglo es: ");
            for (int i = 0; i < array.Length; i++) //Por medio de un ciclo for, recorremos los elementos que hay en el arreglo y los imprimimos.
            {
                Console.Write(array[i] + " ; ");
            }
            for (int j = 0; j <= array.Length - 2; j++) //Método burbuja.
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1]) //Si el elemento actual es mayor al elemento siguiente:
                    {
                        temp = array[i + 1]; //Asigna el elemento siguiente a la variable temporal.
                        array[i + 1] = array[i]; //El elemento siguiente lo asigna al actual.
                        array[i] = temp; //El elemento actual lo asigna a temporal y vuelve a comparar.
                    }
                }
            }
            Console.WriteLine("\n\nArreglo ordenado: ");
            foreach (int aray in array) //Imprimimos los elementos por medio de un Foreach.
                Console.Write(aray + " ; ");
            Console.ReadKey();
        }
    }
}
