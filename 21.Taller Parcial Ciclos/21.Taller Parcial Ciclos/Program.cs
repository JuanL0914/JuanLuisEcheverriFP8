namespace _21.Taller_Parcial_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
            //1.
        {
            float calificacion = 0;
            int contador = 0;
            string respuesta = " ";
            float Resultados = 0;
            do
            {
                Console.WriteLine("Ingrese la calificacion");
                calificacion = int.Parse(Console.ReadLine());

                
                Console.WriteLine("Desea ingresar otra nota? s:si n:no");
                respuesta = Console.ReadLine().ToLower();

                Resultados += calificacion;

                 contador++;
            } while (respuesta == "s");
  
            Console.WriteLine($"El promedio de calificaciones es, {Resultados/contador}");
        }
    }
}
