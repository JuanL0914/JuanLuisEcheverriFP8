using System.Diagnostics;
using System.Net;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

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

            /*            int num1 = 0;
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


                        }*/
            /*            2.El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si cuenta con munición y si se encuentra en estado invencible, crear un programa que: 
                            a.Permita ingresar por teclado si el personaje está en estado invencible(True).
                            b.La cantidad de munición que tiene el personaje en el momento será calculada por el sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#. Ejemplo:  
                             int numero;
                            Random rnd = new Random();
                            numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5 
                            Console.WriteLine(numero);
                            c.Si el estado del personaje es invencible(true) y su cantidad de munición está entre 1 y 10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario no hacer nada.*/


            /*            bool invencible;
                        int municion;

                        Console.WriteLine("¿El personaje está en estado invencible? (True/False):");
                        invencible = bool.Parse(Console.ReadLine());

                        Random rnd = new Random();
                        municion = rnd.Next(1, 11); // Genera un número entre 1 y 10
                        Console.WriteLine($"La cantidad de munición es: {municion}");

                        if (invencible == true && municion >= 1 && municion <= 10)
                        {
                            Console.WriteLine("El personaje está disparando.");
                        }
                        else
                        {
                            Console.WriteLine("El personaje no puede disparar.");
                        }*/
            /*            3.Crear un algoritmo que permita ingresar las coordenadas x, y, para tres puntos: P1(x1, y1), P2(x2, y2), P3(x3, y3).
             *            Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1 P3.La distancia entre dos puntos está dada por la siguiente formula:
                          d = √((x2 - x1)² +(y2 - y1)²) 
                          Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con dichas distancias se puede construir un triángulo, 
                          consultar las condiciones que se deben cumplir para realizar dicha construcción.En caso contrario, decir cuál o cuáles de las condiciones no se cumplen. */

            /*            double x1, y1, x2, y2, x3, y3;
                        double d12, d23, d13;

                        Console.WriteLine("Ingrese las coordenadas del punto P1:");
                        Console.Write("x1: ");
                        x1 = double.Parse(Console.ReadLine());
                        Console.Write("y1: ");
                        y1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese las coordenadas del punto P2:");
                        Console.Write("x2: ");
                        x2 = double.Parse(Console.ReadLine());
                        Console.Write("y2: ");
                        y2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese las coordenadas del punto P3:");
                        Console.Write("x3: ");
                        x3 = double.Parse(Console.ReadLine());
                        Console.Write("y3: ");
                        y3 = double.Parse(Console.ReadLine());


                        d12 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                        d23 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                        d13 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

                        Console.WriteLine($"\nDistancia P1 -> P2: {d12:F2}");
                        Console.WriteLine($"Distancia P2 -> P3: {d23:F2}");
                        Console.WriteLine($"Distancia P1 -> P3: {d13:F2}");


                        bool cond1 = d12 + d23 > d13;
                        bool cond2 = d12 + d13 > d23;
                        bool cond3 = d13 + d23 > d12;

                        Console.WriteLine("\nVerificación de condiciones para formar triángulo:");
                        if (cond1 && cond2 && cond3)
                        {
                            Console.WriteLine("Sí se puede construir un triángulo con estas distancias.");
                        }
                        else
                        {
                            Console.WriteLine("No se puede construir un triángulo porque:");
                            if (!cond1) Console.WriteLine("- La suma de P1P2 + P2P3 no es mayor que P1P3");
                            if (!cond2) Console.WriteLine("- La suma de P1P2 + P1P3 no es mayor que P2P3");
                            if (!cond3) Console.WriteLine("- La suma de P1P3 + P2P3 no es mayor que P1P2");
                        }*/
            /*  4.El personaje de un juego, solo se puede mover en forma horizontal(Izquierda o Derecha), crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
            •	Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la derecha
            •	Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha
            •	En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra dirección” 
            */
            char tecla;

            Console.WriteLine("Ingrese una tecla para mover el personaje (i = izquierda, d = derecha:");
            tecla= char.Parse(Console.ReadLine());  

            if(tecla == 'd')
            {
                Console.WriteLine("El personaje se mueve hacia la derecha");
            }
            else if(tecla == 'i')
            {
                Console.WriteLine("El personaje se mueve hacia la izquierda");
            }
            else
            {
                Console.WriteLine("No se puede mover hacia otra direccion");
            }
        }
    }
}
