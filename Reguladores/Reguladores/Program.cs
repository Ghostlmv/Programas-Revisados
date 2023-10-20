using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Expresión regular para validar una URL simple
        string patronURL = @"^(https?://)?([a-zA-Z0-9.-]+)\.([a-zA-Z]{2,6})(:[0-9]+)?(/[\w.-]*)*(\?\S*)?$";
        // Expresión regular para validar un correo
        string patronCorreo = @"^([a-zA-Z0-9.-]+)\@([a-zA-Z]+)\.([a-zA-Z]{2,3})$";
        // Expresión regular para validar una CURP
        string patronCURP = @"^([A-Z]{4})([0-9]{6})([H|M])([A-Z]{2})([A-Z]{3})([0-9]{2})$";

        Console.WriteLine("¿Qué deseas validar?");
        Console.WriteLine("1. Correo");
        Console.WriteLine("2. CURP");
        Console.Write("Ingresa 1 o 2: ");

        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Console.WriteLine("Escribe un correo: ");
            string correo = Console.ReadLine();

            if (Regex.IsMatch(correo, patronCorreo))
            {
                Console.WriteLine("Correo válido.");
            }
            else
            {
                Console.WriteLine("Correo inválido.");
            }
        }
        else if (opcion == "2")
        {
            Console.WriteLine("Escribe una CURP: ");
            string CURP = Console.ReadLine();

            if (Regex.IsMatch(CURP, patronCURP))
            {
                Console.WriteLine("CURP válida.");
            }
            else
            {
                Console.WriteLine("CURP inválida.");
            }
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }

        Console.ReadKey();
    }
}

//Este código utiliza la clase Regex del espacio de nombres System.Text.RegularExpressions 
//para realizar una coincidencia de patrones con la URL proporcionada. 
//La expresión regular patron en este ejemplo valida una URL que 
//comienza con "http://" o "https://", seguido de un dominio, una posible port, y una posible ruta.

//Puedes ajustar esta expresión regular según tus necesidades específicas de validación de URL.




