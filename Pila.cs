using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_TADPila
{
    class Pila
    {
        private Nodo Cabeza = new Nodo();
        public Pila()
        {
            Cabeza = null;
        }
        //Aqui ingresamos un dato
        public void Ingresar()
        {
            Console.Clear();
            Nodo Nuevo = new Nodo();
            Console.Write("Ingrese un nuevo dato a la pila: ");
            Nuevo.dato = Console.ReadLine();
            Nuevo.Siguiente = Cabeza;
            Cabeza = Nuevo;
        }
        //Aqui imprimimos los datos guardados
        public void Imprimir()
        {
            Console.Clear();
            Nodo Actual = new Nodo();
            Actual = Cabeza;
            if (Cabeza != null)
            {
                Console.WriteLine("Los datos de la TAD Pila ingresados son:");
                while(Actual!=null)
                {
                    Console.WriteLine("" + Actual.dato); 
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
            }
        }

    }
}
