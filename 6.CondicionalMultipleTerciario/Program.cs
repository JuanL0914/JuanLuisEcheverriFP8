/*namespace _6.CondicionalMultipleTerciario
 * 6. Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber: 
Si el día es martes o jueves, se realizará un descuento del 15% por la compra.  
Si el día es lunes o miércoles, se realizará un descuento del 10% por la compra. 
Si el día es viernes o sábado, se realizará un descuento del 20% por la compra. 
Si es domingo no se realiza descuento. 
Visualizar el día, el descuento y el total a pagar por la compra. 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorCompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("ingrese el valor de la compra");
            valorCompra=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de la semana:l:Lunes, m:Martes, x:Miercoles, j:Jueves, v:Viernes, s:Sabado, d:Domingo ");
            dia=Convert.ToChar(Console.ReadLine());

            switch (dia)
            {
                case 'l':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es Lunes decuento de {descuento}, valor total de compra {valorCompra - descuento}");                    
                    break;
                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Martes decuento de {descuento}, valor total de compra {valorCompra - descuento}");
                    break;
                case 'x':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es Miercoles decuento de {descuento}, valor total de compra {valorCompra - descuento}");
                    break;

                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Jueves decuento de {descuento}, valor total de compra {valorCompra - descuento}");
                    break;

                case 'v':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Viernes decuento de {descuento}, valor total de compra {valorCompra - descuento}");
                    break;

                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Sabado decuento de {descuento}, valor total de compra {valorCompra - descuento}");
                    break;
                case 'd':
                    descuento = valorCompra * 0f;
                    Console.WriteLine($"Hoy es Domingo decuento de {descuento}, valor total de compra {valorCompra - descuento}");
                    break;
                default:
                    break;

            }
        }
    }
}
*/

using System.Security.Cryptography;

internal class Program
    //Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.
{
    static void Main(string[] args)
    {
        float num1 = 0;
        float num2 = 0;
        char metodo = ' ';

        Console.WriteLine("Ingrese un numero");
        num1 = Single.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        num2 = Single.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un metodo matematico:+:Suma, -:Resta, *:Multiplicacion /:divicion ");
        metodo = Convert.ToChar(Console.ReadLine());

        switch (metodo)
        {
            case '+':
                Console.WriteLine($"{num1+num2}");
                break;
        }
    }
}      