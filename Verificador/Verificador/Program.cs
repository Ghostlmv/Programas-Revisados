//C# Archivos

using System;
using System.ComponentModel.Design;
using System.IO;

class Program
{

    static void Main()
    {
        string nombreArchivo = "miarchivo.txt";
        string contenido = "Este es el contenido del archivo.";
        int cicloeterno = 1;


        // Crear el archivo y escribir contenido en él
        Console.WriteLine("Buen dia usuario ingrese el nombre del archivo que desea crear");
        nombreArchivo = Console.ReadLine();
        Console.WriteLine("Ingrese el contenido que desea que lleve el archivo");
        contenido = Console.ReadLine();
        while (cicloeterno != 2)
        {
            Console.WriteLine("Que desea hacer en caso de que ingrese cualquier otra letra por defecto se finalizara:\n[E]ditar\n[V]er\n[S]alir");
            char opcion = char.Parse(Console.ReadLine().ToUpper());
            switch (opcion)
            {
                case 'E':
                    Console.WriteLine("Ya puede escribir mas cosas en su archivo:");
                    string editado = Console.ReadLine();
                    contenido = contenido + " " + editado;

                    break;
                case 'V':
                    ver();
                    break;
                case 'S':

                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida");
                    break;
            }
        }
        void ver()
        {
            try
            {
                using (StreamWriter sw = File.CreateText(nombreArchivo))
                {
                    sw.WriteLine(contenido);
                }

                Console.WriteLine($"Archivo '{nombreArchivo}' creado y contenido escrito con éxito.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrió un error al crear o escribir en el archivo: " + e.Message);
            }

            // Leer el archivo que acabamos de crear
            try
            {
                using (StreamReader sr = new StreamReader(nombreArchivo))
                {
                    string linea;
                    string[] condicion = { "si", "mientras" };//textos a buscar
                    Console.WriteLine($"Contenido del archivo '{nombreArchivo}':");
                    contenido = contenido.ToLowerInvariant();
                    while ((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                        int total = 0;
                        foreach (string relevante in condicion)//si encuentra alguna palabra de condicion escribira que existe
                        {
                            string uwu = relevante.ToLowerInvariant();
                            if (contenido.Contains(uwu))
                            {
                                Console.WriteLine("existe una condicion,un ciclo,etc.");
                            }

                        }

                        total++;

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrió un error al leer el archivo: " + e.Message);
            }
            Environment.Exit(0);
        }
        Console.ReadKey();
    }
    
}