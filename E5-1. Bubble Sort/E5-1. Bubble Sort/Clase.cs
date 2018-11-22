using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_1.Bubble_Sort
{
    class Clase
    {
        public void Play()
        {
            int[] array = { 86, 22, 35, 54, 12 }; //Arreglo con elementos ya inicializados.
            int temp; //Variable temporal.
            Console.WriteLine("El arreglo es: "); 
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
                        array[i] = temp; //El elemento actual lo asigna a temporal.
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
