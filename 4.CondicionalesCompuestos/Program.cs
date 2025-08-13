using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CondicionalesCompuestos
{



    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese un sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if (sueldo >= 3000)
            {
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
                //Verdadero
            }
            else
            {

                Console.WriteLine($"La persona {nombre}, no debe abonar impuestos");
                //Falso
            }




            int edad = 0;

            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {

                Console.WriteLine("Bienvenido a mi sitio web");

            }
            else
            {
                Console.WriteLine("lo siento no puedes acceder a este sitio");

            }
            Console.ReadKey();

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Ingrese un numero");
            Console.WriteLine("Ingrese otro numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"La suma entre el primer numero y el segundo es" { numero1 + numero2});



            }
        }           
            
    }
}       
