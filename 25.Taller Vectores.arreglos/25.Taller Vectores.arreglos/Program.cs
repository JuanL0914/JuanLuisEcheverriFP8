namespace _25.Taller_Vectores.arreglos
    //1.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int[] vector; //declarando
                vector = new int[15];//inicializando
                int mayor = 0;
                int menor = 0;

                for (int i = 0; i < vector.Length; i++)
                {
                    Console.WriteLine($"Ingrese el numero entero ´para la posicion {i+1}, con indice {i}:");
                    vector[i]=int.Parse(Console.ReadLine()); 

                    if (i == 0)
                    {
                        mayor = vector[i];
                        menor = vector[i];
                    }
                    else
                    {
                        if (vector[i] > mayor)
                        {
                        mayor = vector[i];
                        }
                        if (vector[i] < menor)
                        {
                        menor = vector[i];
                        }
                    }
                        Console.Clear();
                }
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write(vector[i] + " |");
                }

                Console.WriteLine($"\nEl numero mayor es {mayor}, el numero menor es {menor}");*/

            //2.
            int[] vector; 
            vector = new int[15];
            int mayor = 0;
            int menor = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero entero ´para la posicion {i + 1}, con indice {i}:");
                vector[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    mayor = vector[i];
                    menor = vector[i];
                }
                else
                {
                    if (vector[i] > mayor)
                    {
                        mayor = vector[i];
                    }
                    if (vector[i] < menor)
                    {
                        menor = vector[i];
                    }
                }
                Console.Clear();
            }
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " |");
            }

            Console.WriteLine($"\nEl numero mayor es {mayor}, el numero menor es {menor}");
        }
    }
}

    
