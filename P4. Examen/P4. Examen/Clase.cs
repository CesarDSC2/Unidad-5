using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.Examen
{
    class Clase
    {
        public void Play()
        {
            //No lo logré profe :( saqué este algoritmo de inter xc
            string word = "lorem ipsum dolor sit amet, consectetur adipiscing elit. fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. duis ac massa est.";
            char[] array = new char[word.Length]; //Array tipo char de tamaño de la cadena.
            Console.WriteLine("Palabra ingresada: {0}", word);
            word.CopyTo(0, array, 0, array.Length); //Copiamos la palabra ingresada al arreglo.
            Array.Sort(array);
            Console.WriteLine("Cadena ordenada por caracteres: ");
            for (int i = 0; i < array.Length; i++) //Despliega el array ordenado.
                Console.Write(array[i]);
            Console.ReadLine();
        }
    }
}
