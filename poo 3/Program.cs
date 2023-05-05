using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora com = new Computadora();

            com.PEncendido();
            Console.WriteLine("Ingrese la capacidad del dico de su computadora: ");
            com.Capa_Dis1= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dato para añadir al disco: ");
            int dato = int.Parse(Console.ReadLine());
            com.Añadir(dato);
            int capacidad;
            Console.WriteLine("Ingrese el dato a eliminar: ");
            capacidad = int.Parse(Console.ReadLine());
            com.Eliminar(capacidad);
            com.Pagado();
            Console.ReadKey();
        }
    }
}
