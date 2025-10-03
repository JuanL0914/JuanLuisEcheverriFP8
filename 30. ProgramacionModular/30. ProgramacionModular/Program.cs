namespace _30._ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Mi nombre es lucho");
            //MostrarMensajes("Tengo 19 años");
            //Console.WriteLine($"Edad calculada: {CalcularEdad()}");
            MostrarMensajes($"Tengo {CalcularEdad(2025, 2006)}años");
        }

        //modulo 1 - Procedimiento
        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido a la clase de Programacion Modular");
            MostrarMensajes("(Estoy desde Procedimiento sin parametros)");
        }
        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Modulo 3 - Funciones
        static int CalcularEdad()
        {
            int edad;
            edad = 2025 - 2006;
            return edad;
        }
        
        //Modulo 4
        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
    }
}
