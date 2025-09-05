using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace _11.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador += contador;
            } while (contador<5);

            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");*/

            /*Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10.
             Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar.*/


/*            int numero = 0;
            int contador = 1;
            string respuesta = " ";

            do
            {
                Console.WriteLine("Por Favor ingrese un numero");
                numero=int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                    contador++;
                } while (contador <= 10);
                contador = 1;
                Console.WriteLine("Quiere generar otra tabla de multiplicar: s:si - n:no");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");*/
        
            /*Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
            1.Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” 
            2.Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” 
            El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 
            Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.*/

        }
    }
}
