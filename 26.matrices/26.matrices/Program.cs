namespace _26.matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 2];
            string[,] nombres = new string[2, 3];//rango=6 posiciones
            char[,] caracters = new char[3, 2];//rango=6

            numeros[0, 0] = 25;
            numeros[0, 1] = 46;
            numeros[1, 0] = 42;
            numeros[1, 1] = 78;
            //numeros[1, 2] = 2; error indice fuera del rango

            string[,] apellidos =
            {
                {"Echeverri","Ruiz"},
                {"Cardona","Acevedo" }
            };

            Console.WriteLine(apellidos[1, 1]);

            char[,] caracteres = new char[3, 2];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"caracter posicion {i} , {j}: {caracteres[i, j]}");
                }
            } 
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                       Console.WriteLine($"Ingrese el caracter para la posicion con indices {i},{j}:");
                       caracteres[i,j]=char.Parse(Console.ReadLine());

                    }
                }
                for (int i = 0;i < caracteres.GetLength(0); i++)
                {
                    for(int j = 0; j < caracteres.GetLength(1); j++)
                    {
                        Console.WriteLine($"{caracteres[i,j]} |");
                        Console.WriteLine();
                    }
                    
                    
                Console.WriteLine(caracteres.Length);
                }
            

                
            
        }
    }
}
