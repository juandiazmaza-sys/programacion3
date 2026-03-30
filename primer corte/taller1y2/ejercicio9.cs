using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios.repaso
{
    
    
        public class Libro
        {
            public string Titulo { get; set; }
            public bool EstaPrestado { get; private set; } = false;

            public void Prestar()
            {
                if (!EstaPrestado)
                {
                    EstaPrestado = true;
                    Console.WriteLine($"El libro '{Titulo}' ha sido prestado con éxito.");
                }
                else
                {
                    Console.WriteLine($"Error: El libro '{Titulo}' ya está prestado.");
                }
            }
        }

        public class ejercicio9
        {
            public static void ejecutar()
            {
                Libro miLibro = new Libro { Titulo = "Cien años de soledad" };
                miLibro.Prestar();
                miLibro.Prestar();
            }
        }
    }

