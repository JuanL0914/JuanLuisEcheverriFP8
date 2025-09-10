namespace _17.DoWhile
/*17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10.
Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador = 1;
            string respuesta = " ";

            do
            {
                Console.WriteLine("Por Favor ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                    contador++;
                } while (contador <= 10);
                contador = 1;
                Console.WriteLine("Quiere generar otra tabla de multiplicar: s:si - n:no");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");
        }
    }
}
