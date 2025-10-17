namespace _21.Taller_Parcial_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            float calificacion = 0;
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

                        Console.WriteLine($"El promedio de calificaciones es, {Resultados/contador}");*/
            //2.

            /*int numero = 0;
            int divisor = 1;

            Console.WriteLine("Ingrese un numero entero para mostrar sus divisores:");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Los divisores de {numero} son:");

            while (divisor <= numero)
            {
                if (numero % divisor == 0)
                {
                    Console.WriteLine(divisor);
                }
                divisor++;
            }*/

            //3.
            /*            int baseNum = 0;
                        int exponente = 0;
                        int resultado = 0;
                        char continuar;

                        do
                        {
                            Console.Write("Ingrese la base: ");
                            baseNum = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese el exponente: ");
                            exponente = int.Parse(Console.ReadLine());

                            resultado = 1;
                            int contador = 1;

                            while (contador <= exponente)
                            {
                                resultado = resultado * baseNum;
                                contador++;
                            }

                            Console.WriteLine($"El resultado de {baseNum}^{exponente} es: {resultado}");

                            Console.Write("\n¿Desea realizar otra potenciación? (s/n): ");
                            continuar = char.Parse(Console.ReadLine().ToLower());

                        } while (continuar != 'n');

                        Console.WriteLine("Programa finalizado.");*/


            double tiempo = 0;
            double sumaTiempos = 0;
            double promedio = 0;
            bool tiempoMenor15 = false;
            bool tiempoMayor20 = false;

            for (int dia = 1; dia <= 10; dia++)
            {
                Console.Write($"Ingrese el tiempo (en minutos) del día {dia}: ");
                tiempo = double.Parse(Console.ReadLine());

                sumaTiempos = sumaTiempos + tiempo;

                if (tiempo < 15)
                {
                    tiempoMenor15 = true;
                }

                if (tiempo > 20)
                {
                    tiempoMayor20 = true;
                }
            }

            promedio = sumaTiempos / 10;

            Console.WriteLine($"\nPromedio de tiempos: {promedio:F2} minutos");

            if (!tiempoMayor20 && tiempoMenor15 && promedio <= 18)
            {
                Console.WriteLine("El atleta es APTO para la competencia.");
            }
            else
            {
                Console.WriteLine("El atleta NO es apto para la competencia.");
                if (tiempoMayor20)
                {
                    Console.WriteLine("Falló porque hizo más de 20 minutos en alguna prueba.");
                }
                if (!tiempoMenor15)
                {
                    Console.WriteLine("Falló porque no tuvo ningún tiempo menor de 15 minutos.");
                }
                if (promedio > 18)
                {
                    Console.WriteLine("Falló porque su promedio es mayor a 18 minutos.");
                }
            }

        }
    }
}
