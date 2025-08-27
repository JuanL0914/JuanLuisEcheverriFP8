using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace _9.Parcial__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el sexo (H o M) H: Hombre  M: Mujer ");
            string sexo = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el ultimo digito de tu documento (0-9): ");
            int digito = Convert.ToInt32(Console.ReadLine());

            bool Ingles = false;

            if (edad == 15)
            {
                Console.WriteLine("¿Dominas el Ingles? (si/no): ");
                string respuesta = Console.ReadLine();
                Ingles = (respuesta == "si");
            }
            string grupo;

            if ((sexo == "M" && edad >= 16 && edad <= 20 && (digito == 0 || digito == 4 || digito == 8)) ||
               (sexo == "H" && edad >= 18 && edad <= 22 && (digito == 1 || digito == 5 || digito == 9)))
            {
                grupo = "A";
            }

            else if ((sexo == "M" && edad >= 21 && edad <= 25 && (digito == 3 || digito == 7)) ||
               (sexo == "H" && edad >= 23 && edad <= 26 && (digito == 2 || digito == 6)))
            {
                grupo = "B";
            }

            else if (edad == 15 && Ingles)
            {
                grupo = "C";
            }

            else
            {
                grupo = "D";
            }

            Console.WriteLine($"la persona pertenece al grupo {grupo}");
        }
    }
}
