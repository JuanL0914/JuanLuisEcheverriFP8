using System.Diagnostics;

namespace _8.Taller_Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes.*/

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;
            Console.WriteLine("Ingrese un numero 1:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero 2:");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero 3:");
            num3 = Int32.Parse(Console.ReadLine());



            if (num1 == num2 || num1 == num3 || num2 == num3)
            {

                Console.WriteLine("Todos los numeros deben ser diferentes");



            }
            else 
            { 
            
                mayor = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
                Console.WriteLine($"El numero mayor es : {mayor}");
            
            
            }

            Console.WriteLine
            
        }
    }
}
