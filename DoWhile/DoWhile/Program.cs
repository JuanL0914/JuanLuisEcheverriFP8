namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador += contador;
            } while (contador < 5);

            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");
        }
    }
}
