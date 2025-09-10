namespace _13.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 13.Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar.Al usuario le corresponde ingresar la cantidad de números que va a introducir.
El algoritmo debe escribir en pantalla: 
La cantidad de números introducidos que son mayores que 0
La cantidad de números introducidos menores que 0
La cantidad de números iguales a 0.*/
            int contador = 1;
            int mayores = 0;
            int menores = 0;
            int iguales = 0;
            int cantidadNumeros = 0;

            Console.WriteLine("Ingrese la cantidad de numeros");
            cantidadNumeros = int.Parse(Console.ReadLine());

            while (contador <= cantidadNumeros)
            {
                Console.WriteLine($"Ingrese el numero {contador + 1}: ");
                int numero = int.Parse(Console.ReadLine());

                if (contador > 0)
                {
                    mayores++;
                }
                else if (contador < 0)
                {
                    menores++;
                }
                else
                {
                    iguales++;
                }
                contador++;
            }
            Console.WriteLine($"la cantidad de numeros mayores a 0 son {mayores}");
            Console.WriteLine($"la cantidad de numeros menores a 0 son {menores}");
            Console.WriteLine($"la cantidad de numeros iguales a 0 son {iguales}");
        }
    }
}
