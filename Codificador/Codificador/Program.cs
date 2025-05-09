using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("=== Menú de ejercicios ===");
        Console.WriteLine("1. Ejercicio 1");
        Console.WriteLine("2. Ejercicio 2");
        Console.WriteLine("3. Ejercicio 3");
        Console.Write("Elige un ejercicio (1-3): ");

        string opcion = Console.ReadLine();
        Console.WriteLine();

        if (opcion == "1")
        {
            Console.Write("Introduce una cadena para el ejercicio 1: ");
            string cadena = Console.ReadLine();
            ejercicio1(cadena);
        }
        else if (opcion == "2")
        {
            Console.Write("Introduce una cadena para el ejercicio 2: ");
            string cadena = Console.ReadLine();
            ejercicio2(cadena);
        }
        else if (opcion == "3")
        {
            Console.Write("Introduce una cadena para el ejercicio 3: ");
            string cadena = Console.ReadLine();
            ejercicio3(cadena);
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    static void ejercicio1(string cadena)
    {
        int estado = 0;
        bool valida = true;
        int i = 0;

        while (i < cadena.Length && valida)
        {
            char simbolo = cadena[i];

            if (estado == 0)
            {
                if (simbolo == 'a')
                {
                    estado = 0;
                }
                else if (simbolo == 'c')
                {
                    if (i == 0)
                        valida = false;
                    else
                        estado = 1;
                }
                else
                {
                    valida = false;
                }
            }
            else if (estado == 1)
            {
                if (simbolo == 'b')
                {
                    estado = 1;
                }
                else
                {
                    valida = false;
                }
            }

            i++;
        }

        if (valida && estado >= 1 && cadena.Contains("c") && cadena[0] == 'a')
        {
            Console.WriteLine("Cadena válida");
        }
        else
        {
            Console.WriteLine("Cadena inválida");
        }
    }

    static void ejercicio2(string cadena)
    {
        bool valida = true;
        int i = 0;

        if (cadena.Length < 4)
        {
            valida = false;
        }
        else
        {
            if (cadena[0] != '1' || cadena[1] != '1')
                valida = false;

            i = 2;
            bool hayCeros = false;

            while (i < cadena.Length - 1 && valida)
            {
                if (cadena[i] == '0')
                {
                    hayCeros = true;
                }
                else
                {
                    valida = false;
                }
                i++;
            }

            if (cadena[cadena.Length - 1] != '1')
                valida = false;

            if (!hayCeros)
                valida = false;
        }

        if (valida)
        {
            Console.WriteLine("Cadena válida");
        }
        else
        {
            Console.WriteLine("Cadena inválida");
        }
    }

    static void ejercicio3(string cadena)
    {
        bool valida = true;

        if (cadena.Length < 2)
        {
            valida = false;
        }
        else if (cadena[0] != 'a' || cadena[cadena.Length - 1] != 'c')
        {
            valida = false;
        }
        else
        {
            for (int i = 1; i < cadena.Length - 1; i++)
            {
                if (cadena[i] != 'b' && cadena[i] != 'c')
                {
                    valida = false;
                    break;
                }
            }
        }

        if (valida)
        {
            Console.WriteLine("Cadena válida");
        }
        else
        {
            Console.WriteLine("Cadena inválida");
        }
    }
}






