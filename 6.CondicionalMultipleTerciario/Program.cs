/*namespace _6.CondicionalMultipleTerciario
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