namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear un algoritmo que permita calcular la factorial de un numero dado por el usuario. (5! = 1*2*3*4*5)
            /*            int contador = 1;
                        int acumulador = 1;
                        int factorial = 0;*/

            //Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99.
            /*          int contador = 1;
                        int suma = 0;

                        while (contador <= 99)
                        {
                            suma += contador;
                            Console.WriteLine($"{contador} - {suma}");
                            contador += 2;
                        }
                        Console.WriteLine($"la suma de los numeros impares hasta el 99 es: {suma}");*/

            /* Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar.Al usuario le corresponde ingresar la cantidad de números que va a introducir.
            El algoritmo debe escribir en pantalla: 
            La cantidad de números introducidos que son mayores que 0
            La cantidad de números introducidos menores que 0
            La cantidad de números iguales a 0.*/
            int contador = 1;
            int mayores = 0;
            int menores = 0;
            int iguales = 0;
            int cantidadNumeros = 0;

            Console.WriteLine("Ingrese la cantidad de numeros");
            cantidadNumeros = int.Parse(Console.ReadLine());

            while (contador <= cantidadNumeros)
            {
                Console.WriteLine($"Ingrese el numero {contador + 1}: ");
                int numero = int.Parse(Console.ReadLine());

                if (contador > 0)
                {
                    mayores++;
                }
                else if (contador < 0)
                {
                    menores++;
                }
                else
                {
                    iguales++;
                }
                contador++;
            }
                Console.WriteLine($"la cantidad de numeros mayores a 0 son {mayores}");
                Console.WriteLine($"la cantidad de numeros menores a 0 son {menores}");
                Console.WriteLine($"la cantidad de numeros iguales a 0 son {iguales}");

            //Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.
            /*int rango = 0;
            int contadorPares = 0;
            int contador = 1;

            Console.WriteLine("Ingrese el rango a evaluar");
            rango=int.Parse(Console.ReadLine());

            while (contador <= rango)
            {
                if (contador % 2 == 0)
                {
                    contadorPares++;
                }

                contador++;
            }
            Console.WriteLine($"La cantidad de numeros pares de 1 hasta {rango} es: {contadorPares}");*/
        }  
    }
}

