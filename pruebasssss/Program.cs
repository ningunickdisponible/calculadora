using System;

namespace pruebasssss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora!");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Ingrese un numero");
            int var1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            int var2 = int.Parse(Console.ReadLine());
            bool entra = true;
            while (entra)
            {
                entra = false;
                Console.WriteLine("Ingrese que operacion quiere hacer:");
                Console.WriteLine("\t S-Suma");
                Console.WriteLine("\t R-Resta");
                Console.WriteLine("\t M-Multiplicacion");
                Console.WriteLine("\t D-Division");

                string operacion = Console.ReadLine();
                switch (operacion.ToUpper())
                {
                    case "S":
                        sumar(var1, var2);
                        break;
                    case "R":
                        Console.WriteLine(var1 - var2);
                        break;
                    case "M":
                        Console.WriteLine(var1 * var2);
                        break;
                    case "D":
                        if (var2 == 0)
                        {
                            Console.WriteLine("No se puede dividir por cero, reingrese otra opcion");
                            entra = true;
                        }
                        else
                        {
                            if ((decimal)var1 / var2 != (var1 / var2))
                            {
                                Console.WriteLine((decimal)var1 / var2);
                            }
                            else
                            {
                                Console.WriteLine(var1 / var2);
                            }
                        }
                        
                        break;
                    default:
                        //Aca podes poner cualquier cosa, total la condicion del while, solamente va a salir si es S, R, M o D.
                        Console.WriteLine("La opcion elegida no es valida, reingrese otra opcion");
                        entra = true;
                        break;
                }
            }
        }

        static void sumar(int x, int y)
        {
            Console.WriteLine(x + y);
        }


    }
}
