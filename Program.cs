using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_TADPila
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            pila.Ingresar();
            pila.Ingresar();
            pila.Ingresar();
            pila.Ingresar();
            pila.Imprimir();
            Console.ReadLine();
        }
    }
}
