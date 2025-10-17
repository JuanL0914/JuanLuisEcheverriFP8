namespace _10.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. crear un algoritmo que permita calcular la factorial de un numero dado por el usuario. (5! = 1*2*3*4*5)
            int contador = 1;
            int acumulador = 1;
            int numero = 0;

            Console.WriteLine("Ingrese un numero para calcular su factorial:");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("No se puede calcular el factorial de un numero negativo");
            }
            else
            {
                while (contador <= numero)
                {
                    acumulador = acumulador + contador;
                    contador++;
                }
                Console.WriteLine($"El factorial de {numero} es: {acumulador}");
            }
        }
    }
}
