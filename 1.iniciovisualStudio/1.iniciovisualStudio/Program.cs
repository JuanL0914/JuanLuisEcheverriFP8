using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.iniciovisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion e inicializacion de variables
            string nombre="Juan";
            const string iva = "19%";
            string apellidos = "Echeverri Ruiz";
            Console.Write(nombre+" Bienvenido al curso de Fundamentos de Programacion\n");
            nombre = "Luis";
            //iva = "20%"; No puedo cambiar el valor de iva por ser una constante
            Console.Write("\t" + nombre +" "+ apellidos +" "+ iva);
            Console.ReadKey();
        }
    }
}
