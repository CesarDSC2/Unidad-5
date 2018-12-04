using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3.Examen
{
    class Proceso
    {
        public void Shell(int[] array)
        {
            int n = array.Length;
            int colum = n / 2; //Dividimos el array en 2 partes
            int temp; //Variable auxiliar

            while (colum > 0)
            {
                for (int i = 0; i + colum < n; i++)
                {
                    int j = i + colum; //Se crea una variable auxiliar para guardar el valor actual.
                    temp = array[j]; //Se asigna la variable temporal al arreglo.

                    while (j - colum >= 0 && temp < array[j - colum]) 
                    {
                        array[j] = array[j - colum];
                        j = j - colum; 
                    }

                    array[j] = temp; //El arreglo adquiere un nuevo valor que guardamos en la variable temporal.
                }

                colum = colum / 2; //Volvemos a dividir el array.
            }
        }
    }
}
