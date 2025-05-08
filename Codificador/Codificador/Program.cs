using System;

class AutomataSimple
{
    static void Main()
    {
     
        char[] alfabeto = { 'a', 'b', 'c' };

   
        string[] cadenasValidas = { "aacb", "aaac", "acbb" };

        Console.WriteLine("Introduce una cadena usando el alfabeto {a, b, c}:");
        string entrada = Console.ReadLine();


        foreach (char c in entrada)
        {
            if (Array.IndexOf(alfabeto, c) == -1)
            {
                Console.WriteLine($"Cadena inválida. El símbolo '{c}' no pertenece al alfabeto {{a, b, c}}.");
                return;
            }
            Console.ReadKey();
        }


        bool esValida = false;
        foreach (string cadena in cadenasValidas)
        {
            if (entrada == cadena)
            {
                esValida = true;
                break;
            }
        }

        if (esValida)
        {
            Console.WriteLine("La cadena coincide con una de las definidas.");
        }
        else
        {
            Console.WriteLine("La cadena no coincide con ninguna de las definidas.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir");
        Console.ReadKey(); 
    }
}

