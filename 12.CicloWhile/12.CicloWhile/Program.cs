namespace _12.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 12. Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99.
            int contador = 1;
            int suma = 0;

            while (contador <= 99)
            {
                suma += contador;
                Console.WriteLine($"{contador} - {suma}");
                contador += 2;
            }
            Console.WriteLine($"la suma de los numeros impares hasta el 99 es: {suma}");
        }
    }
}
