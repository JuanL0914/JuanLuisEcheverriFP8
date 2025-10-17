namespace _11.CicloWhile
    //11. Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo.Se debe mostrar por pantalla el total de la suma de los números ingresados.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int suma = 0;

            Console.WriteLine("Ingrese numeros enteros positivos (ingrese un numero negativo para finalizar: )");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                suma = suma + numero;
                Console.WriteLine("Ingrese otro numero:");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La suma total de los numeros es: {suma}");
        }
    }
}
