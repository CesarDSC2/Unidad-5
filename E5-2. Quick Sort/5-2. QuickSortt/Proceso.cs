using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2.QuickSortt
{
    class Proceso
    {
        double[] Array; //Creamos un vector de la clase Proceso.
        public Proceso(double[] Array) //Recibimos como párametro el Vector ya inicializado de la Clase.
        {
            this.Array = Array; //Asignamos valores del Vector.
            Play(Array, 0, Array.Length - 1); //Llamamos al método Play que ejecuta el algoritmo necesario para realizar el QuickSort.
            Desplegar();
        }

        private void Play(double[] array, int primero, int ultimo) //Recibe como párametros el Vector, el primer índice y el último índice del vector.
        {
            int x, y, central; //Creamos variables.
            double pivote;
            central = (primero + ultimo) / 2; //Se hace para iniciar el pivote desde el centro del vector.
            pivote = array[central]; //Se crea un pivote el cual será nuestro puntero.
            x = primero;
            y = ultimo;
            do
            {
                while (array[x] < pivote)
                {
                    x++; //x aumenta mientras el primer ídice sea menor al pivote.
                }
                while (array[y] > pivote)
                {
                    y--; //y decrementa mientras el último ídice sea mayor al pivote.
                }
                if (x <= y) //Si el primero es menor o igual a el último
                {
                    double auxiliar; //Creamos una variable auxiliar
                    auxiliar = array[x];
                    array[x] = array[y];
                    array[y] = auxiliar;
                    x++;
                    y--;
                }
            } while (x <= y); //Todo eso siempre y cuando el primero sea menor o igual al segundo.

            if (primero < y) 
            {
                Play(array, primero, y); //De manera recursiva, si el primero es menor al segundo, se mandan primero los párametros de el primero y el segundo elemento.
            }
            if (x < ultimo)
            {
                Play(array, x, ultimo); //Y cuando el primero es menor que el último, se mandan despues los párametros de el primero y el último.
            }
        }
        int i;
        private void Desplegar() //Despliega los elementos ordenados.
        {

            Console.WriteLine("\n\n- Quick Sort:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(" {0} ;", Array[i]);
            }
            Console.Write("\n\nPresione enter.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
