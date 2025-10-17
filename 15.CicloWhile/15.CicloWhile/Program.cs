using System.Reflection.Emit;

namespace _15.CicloWhile
    //15.Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidades variables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes = 1;
            double deposito = 0;
            double ahorroTotal = 0;

            Console.WriteLine("Programa para calcular el ahorro anual con depositos mensuales variable.");

            while (mes <= 12)
            {
                Console.WriteLine($"Ingrese la cantidad que va a depositar en el mes {mes}:");
                deposito = double.Parse( Console.ReadLine());

                ahorroTotal = ahorroTotal + deposito;
                Console.WriteLine($"Ahorro acumulado hasta el mes {mes}: {ahorroTotal}");
                mes++;
            }
            Console.WriteLine($"El ahorro total al final del año es {ahorroTotal}");
        }
    }
}
