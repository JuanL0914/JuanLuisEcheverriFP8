namespace _16.CicloWhile
//16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto.Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numeroSecreto = rnd.Next(1, 101); // número aleatorio entre 1 y 100
            int intento = 0;

            Console.WriteLine("Adivina el número entre 1 y 100:");

            while (intento != numeroSecreto)
            {
                Console.Write("Ingresa tu intento: ");
                intento = int.Parse(Console.ReadLine());

                if (intento > numeroSecreto)
                {
                    Console.WriteLine("El número es demasiado alto.\n");
                }
                else if (intento < numeroSecreto)
                {
                    Console.WriteLine("El número es demasiado bajo.\n");
                }
                else
                {
                    Console.WriteLine($"¡Correcto! El número era {numeroSecreto}.");
                }
            }
        }
    }
}
