namespace _29.Taller_Matrices
{
    /*1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
pantalla la suma de los elementos de cada columna.
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int[,] numeros = new int[4, 4];
              int[] sumaColumnas = new int[numeros.GetLength(1)];
              //recorrer la matrix para llenarla
              for (int i = 0; i < numeros.GetLength(0); i++)
              {
                  for (int j = 0; j < numeros.GetLength(1); j++)
                  {
                      Console.WriteLine($"Ingrese el valor para la posicion {i},{j}");

                      numeros[i,j] = int.Parse(Console.ReadLine());
                  }
              }

              //recorrer la matrix para mostrarla en pantalla
              for (int i = 0; i < numeros.GetLength(0); i++)
              {
                  for (int j = 0; j < numeros.GetLength(1); j++)
                  {
                      Console.Write($"{numeros[i,j]} |");
                  }
                  Console.WriteLine( );
              //recorrer la matrix para mostrarla en sumar los elementos de cada columna
              }
              for (int i = 0; i < numeros.GetLength(1); i++)
              {
                  for (int j = 0; j < numeros.GetLength(0); j++)
                  {
                      sumaColumnas[i] += numeros[j,i];
                  }
              }
              //Recorrer el vector y mostrar la suma de cada columna
              for (int i = 0;i < numeros.GetLength(0); i++)
              {
                  Console.Write($"{sumaColumnas[i]} |");
              }*/



            /*2.Desarrollar un programa que crea una matriz de n filas* m columnas, el usuario ingresa
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
            matriz con el intercambio de filas*/
            /*int filas = 0;
            int columnas = 0;
            Console.Write("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            columnas = int.Parse(Console.ReadLine());

           
            char[,] matriz = new char[filas, columnas];

           
            Console.WriteLine("Ingrese los caracteres de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz Original:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

           
            for (int j = 0; j < columnas; j++)
            {
                char temp = matriz[0, j];
                matriz[0, j] = matriz[filas - 1, j];
                matriz[filas - 1, j] = temp;
            }

        
            Console.WriteLine("Matriz con la primera y última fila intercambiadas:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();



            }*/

            //3.
            /*
                        int[,] matriz = new int[5, 5];
                        int[] frecuencia = new int[10]; 

                        Random rnd = new Random();

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                matriz[i, j] = rnd.Next(1, 11); 
                            }
                        }

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                int numero = matriz[i, j];
                                frecuencia[numero - 1]++; 
                            }
                        }

                        Console.WriteLine("Matriz generada (5x5):");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write(matriz[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("\nFrecuencia de cada número del 1 al 10:");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Número {i + 1}: {frecuencia[i]} veces");
                        }*/

            //4.
            int[,] matriz = new int[4, 4];
            int[] sumaFilas = new int[4];
            int[] sumaColumnas = new int[4];

            Random rnd = new Random();


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = rnd.Next(1, 10);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumaFilas[i] += matriz[i, j];
                    sumaColumnas[j] += matriz[i, j];
                }
            }

          
            Console.WriteLine("Matriz generada (4x4):");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSuma de cada fila:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Fila {i + 1}: {sumaFilas[i]}");
            }

            Console.WriteLine("\nSuma de cada columna:");
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($"Columna {j + 1}: {sumaColumnas[j]}");
            }
        }
    }
}
