using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Examen
{
    class Proceso
    {
        public void Radix(int[] array)
        {
            
            int i, j;
            int[] tmp = new int[array.Length];
            for (int k = 31; k > -1; --k) //Si "k" es mayor a -1, i y j = 0, si no, fin ciclo. (k=31 porque es la cantidad de bits -1 de tipo int)
            {
                j = 0;
                for (i = 0; i < array.Length; ++i) //Si i es menor al tamaño del vector entra al ciclo, si no, linea 26.
                {
                    bool traslado = (array[i] << k) >= 0; //Variable tipo booleana asignada a (Arreglo[indice actual] (desplazamiento hacia la izquierda) del valor actual de k)
                    if (k == 0 ? !traslado : traslado) //Si k == 0 devuelve una negación lógica, si no, devuelve traslado.
                        array[i - j] = array[i];
                    else
                        tmp[j++] = array[i];
                }
                Array.Copy(tmp, 0, array, array.Length - j, j); //Copia un rango de elemento en un arreglo hacia otro. (k disminuye y vuelve iniciar el ciclo, linea 15)
            }
        }
    }
}
