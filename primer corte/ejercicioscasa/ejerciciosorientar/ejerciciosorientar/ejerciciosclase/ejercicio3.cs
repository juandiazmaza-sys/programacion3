using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejerciciosorientar.ejerciciosclase
{
    public class ejercicio3
    {
        public class Estudiante
        {
            // Propiedades
            public string Nombre { get; set; }
            public string Materia { get; set; }
            public double[] Notas { get; set; } 

            public Estudiante(string nombre, string materia)
            {
                Nombre = nombre;
                Materia = materia;
                Notas = new double[3];

           
            public double CalcularPromedio()
            {
               
                double suma = 0;
                foreach (double nota in Notas)
                {
                    suma += nota;
                }
                return suma / Notas.Length;
            }

            public string EstadoFinal()
            {
                double promedio = CalcularPromedio();
                return promedio >= 3.0 ? "✅ APROBADO" : "❌ REPROBADO";
            }

            public void MostrarReporte()
            {
                double promedio = CalcularPromedio();
                Console.WriteLine("\n===============================");
                Console.WriteLine($"      REPORTE ACADÉMICO        ");
                Console.WriteLine("===============================");
                Console.WriteLine($"Estudiante: {Nombre}");
                Console.WriteLine($"Materia:    {Materia}");
                Console.WriteLine($"Parcial 1:  {Notas[0]:N1}");
                Console.WriteLine($"Parcial 2:  {Notas[1]:N1}");
                Console.WriteLine($"Parcial 3:  {Notas[2]:N1}");
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"PROMEDIO:   {promedio:N2}");
                Console.WriteLine($"ESTADO:     {EstadoFinal()}");
                Console.WriteLine("===============================");
            }
        }

        public void Ejecutar()
        {
            Console.WriteLine("--- SISTEMA DE CALIFICACIONES ---");

            Console.Write("Nombre del estudiante: ");
            string nom = Console.ReadLine();

            Console.Write("Materia: ");
            string mat = Console.ReadLine();

            Estudiante alumno = new Estudiante(nom, mat);

           
            for (int i = 0; i < 3; i++)
            {
                bool notaValida = false;
                while (!notaValida)
                {
                    Console.Write($"Ingrese la nota del Parcial {i + 1} (0.0 - 5.0): ");
                    if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 5)
                    {
                        alumno.Notas[i] = nota;
                        notaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("⚠️ Entrada inválida. Ingrese un número entre 0 y 5.");
                    }
                }
            }

         
            alumno.MostrarReporte();
        }
    }
}