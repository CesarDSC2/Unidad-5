using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_3.Radix
{
    class Clase
    {
        public void Play()
        {
            int[] ArrayA = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 }; //Creamos el vector con los valores que tendrá cada elemento.
            int[] ArrayB = new int[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            int[] ArrayC = new int[] { 10, 40, 36, 5, 24, 2, 5, 8 };
            int[] ArrayD = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            int[] ArrayE = new int[] { 25, 108, 1024, 12, 351, 251, 39 };

            Console.WriteLine("1.-Vector sin alterar:"); //Imprimimos los elementos del vector que aún no recibe cambios.
            foreach (var item in ArrayA)
            {
                Console.Write(" {0} ;", item);
            }
            Proceso obj = new Proceso(); //Se crea un objeto 
            obj.Radix(ArrayA); //Mandamos como párametro el vector y ejecuta el método.
            Console.WriteLine("\n\n- Radix: ");
            foreach (var item in ArrayA)
            {
                Console.Write(" {0} ;", item);
            }
            Console.Write("\n\nPresione enter.");
            Console.ReadKey();
            Console.Clear();
            //
            Console.WriteLine("2.-Vector sin alterar:");
            foreach (var item in ArrayB)
            {
                Console.Write(" {0} ;", item);
            }
            Proceso obj2 = new Proceso();
            obj.Radix(ArrayB);
            Console.WriteLine("\n\n- Radix: ");
            foreach (var item in ArrayB)
            {
                Console.Write(" {0} ;", item);
            }
            Console.Write("\n\nPresione enter.");
            Console.ReadKey();
            Console.Clear();
            //
            Console.WriteLine("3.-Vector sin alterar:");
            foreach (var item in ArrayC)
            {
                Console.Write(" {0} ;", item);
            }
            Proceso obj3 = new Proceso();
            obj.Radix(ArrayC);
            Console.WriteLine("\n\n- Radix: ");
            foreach (var item in ArrayC)
            {
                Console.Write(" {0} ;", item);
            }
            Console.Write("\n\nPresione enter.");
            Console.ReadKey();
            Console.Clear();
            //
            Console.WriteLine("4.-Vector sin alterar:");
            foreach (var item in ArrayD)
            {
                Console.Write(" {0} ;", item);
            }
            Proceso obj4 = new Proceso();
            obj.Radix(ArrayD);
            Console.WriteLine("\n\n- Radix: ");
            foreach (var item in ArrayD)
            {
                Console.Write(" {0} ;", item);
            }
            Console.Write("\n\nPresione enter.");
            Console.ReadKey();
            Console.Clear();
            //
            Console.WriteLine("5.-Vector sin alterar:");
            foreach (var item in ArrayE)
            {
                Console.Write(" {0} ;", item);
            }
            Proceso obj5 = new Proceso();
            obj.Radix(ArrayE);
            Console.WriteLine("\n\n- Radix: ");
            foreach (var item in ArrayE)
            {
                Console.Write(" {0} ;", item);
            }
            Console.Write("\n\nPresione enter.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
