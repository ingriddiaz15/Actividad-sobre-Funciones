using System;
using System.Linq;
namespace Actividad_Funciones
{
    class Program
    {
        public static int vradio;
        public static int vbase;
        public static int valtura;
        public static double resultado;
        public static double pi = 3.14;
        public static string opcion;
        public static void area_triangulo(double pi)
        {
            Console.WriteLine("USTED ESCOGIO CALCULAR EL AREA DEL TRIANGULO\n");
            Console.WriteLine("Cual es la base:");
            vbase = Int32.Parse(Console.ReadLine());
            Double x = (Double)vbase;
            Console.WriteLine("Cual es la altura:");
            valtura = Int32.Parse(Console.ReadLine());
            Double y = (Double)valtura;
            resultado = (valtura * vbase) / 2;
            System.Console.WriteLine("El resultado es: " + resultado);
        }
        public static void area_circulo(double pi)
        {
            Console.WriteLine("USTED ESCOGIO CALCULAR EL AREA DEL CIRCULO\n");
            Console.WriteLine("Cual es el radio:");
            vradio = Int32.Parse(Console.ReadLine());
            Double x = (Double)vradio;
            resultado = pi * (x * x);
            System.Console.WriteLine("El resultado es: " + resultado);
        }
        public static void area_rectangulo(double pi)
        {
            Console.WriteLine("USTED ESCOGIO CALCULAR EL AREA DEL RECTANGULO\n");
            Console.WriteLine("Cual es la base:");
            vbase = Int32.Parse(Console.ReadLine());
            Double x = (Double)vbase; menu();
            Console.WriteLine("Cual es la altura:");
            valtura = Int32.Parse(Console.ReadLine());
            Double y = (Double)valtura;
            resultado = vbase * valtura;
            System.Console.WriteLine("El resultado es: " + resultado);
        }
        public static void menu_opciones()
        {
            Console.WriteLine("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir\n");

        }
        static void Main(string[] args)
        {
            string marco = string.Concat(Enumerable.Repeat("*", 50));
            System.Console.WriteLine(marco + "\n\t PROGRAMA PARA GEOMETRIA \n" + marco);
            Console.WriteLine("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir\n");
            while (opcion != "s")
            {
                System.Console.WriteLine("Ingrese su opcion: ");
                opcion = Console.ReadLine();
                System.Console.WriteLine();
                Console.Clear();
                if (opcion == "s")
                {
                    System.Console.WriteLine("\n\nGRACIAS POR USAR EL PROGRAMA DE CALCULO GEOMETRICO\n\n");
                    break;
                }
                else if (opcion == "c")
                {
                    area_circulo(pi);
                    string marco2 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco2);
                    menu_opciones();
                }
                else if (opcion == "r")
                {
                    area_rectangulo(pi);
                    string marco3 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco3);
                    menu_opciones();
                }
                else if (opcion == "t")
                {
                    area_triangulo(pi);
                    string marco4 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco4);
                    menu_opciones();
                }
                else
                {
                    System.Console.WriteLine("OH! AL PARECER OCURRIO UN ERROR!\nPOR FAVOR INTRODUZCA UNA DE LA LETRAS QUE SE LE MUESTRA EN EL MENU!");
                    System.Console.WriteLine("PARA CONTINUAR PRESIONE UNA TECLA!!!");
                    Console.ReadKey();
                    Console.Clear();
                    menu_opciones();
                }
            }
        }
    }
}