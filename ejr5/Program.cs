using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejr5
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad;
            string nombre;


            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();




            Console.Write("Ingrese edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad > 18)

            {
                Console.Write("Nombre: "+ nombre);
                Console.Write("Edad  : "+edad);
                
            }

            Console.ReadLine();
        
        }
    }
}
