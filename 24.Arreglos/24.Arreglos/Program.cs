using System.Xml.Linq;

namespace _24.Arreglos
    //Crear arreglo llamado "numeros" de 100 elementos asignar el número 10 en cada una de las posiciones del arreglo.Leer el contenido de cada elemento y escribirlo en pantalla.  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Posición {i + 1}: {numeros[i]}");
            }
        }
    }
}
