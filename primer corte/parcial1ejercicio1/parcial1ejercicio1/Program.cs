

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


public class GestorPacientes : IGestionable
{
    private string Ruta = "pacientes.csv";

   
    private List<Paciente> LeerArchivo()
    {
        var lista = new List<Paciente>();

        if (!File.Exists(Ruta))
            return lista;

        var lineas = File.ReadAllLines(Ruta);

        foreach (var linea in lineas)
        {
            var datos = linea.Split(';');

            if (datos.Length == 4)
            {
                lista.Add(new Paciente
                {
                    Id = int.Parse(datos[0]),
                    Nombre = datos[1],
                    Edad = int.Parse(datos[2]),
                    Especie = (Especies)Enum.Parse(typeof(Especies), datos[3])
                });
            }
        }

        return lista;
    }

    // Guardar archivo
    private void GuardarArchivo(List<Paciente> lista)
    {
        try
        {
            var lineas = lista.Select(p => p.ToCSV());
            File.WriteAllLines(Ruta, lineas);
              Console.WriteLine("guardado en paciente.csv");
        }
        catch (Exception ex)
        {
            Console.WriteLine("error: " + ex.Message);
        }
    }

    public void Crear()
    {
        try
        {
            Console.Write("Id: ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            Console.Write("nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("edad: ");
            int edad;
            if (!int.TryParse(Console.ReadLine(), out edad))
            {
                Console.WriteLine("valor invalido");
                return;
            }

            Console.Write("especie (0 perro, 1 gato, 2 ave): ");
            int tipo;
            if (!int.TryParse(Console.ReadLine(), out tipo))
            {
                Console.WriteLine("valor invalido");
                return;
            }

            var lista = LeerArchivo();

            lista.Add(new Paciente
            {
                Id = id,
                Nombre = nombre,
                Edad = edad,
                Especie = (Especies)tipo
            });

            GuardarArchivo(lista);

           
        }
        catch (Exception ex)
        {
            Console.WriteLine("error: " + ex.Message);
        }
    }

    public void Listar()
    {
        var lista = LeerArchivo();

        if (lista.Count == 0)
        {
            Console.WriteLine("no hay pacientes");
            return;
        }

        foreach (var p in lista)
        {
            Console.WriteLine($"ID: {p.Id} | nombre: {p.Nombre} | edad: {p.Edad} | especie: {p.Especie}");
        }
    }

    public void Modificar()
    {
        var lista = LeerArchivo();

        Console.Write("ID: ");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.WriteLine("Valor invalido");
            return;
        }

        var paciente = lista.FirstOrDefault(p => p.Id == id);

        if (paciente == null)
        {
            Console.WriteLine("no encontrado");
            return;
        }

        Console.Write("ingres el nuevo nombre: ");
        paciente.Nombre = Console.ReadLine();

        Console.Write("ingrese la nueva edad: ");
        int edad;
        if (int.TryParse(Console.ReadLine(), out edad))
        {
            paciente.Edad = edad;
        }

        Console.Write("Nueva especie (0 perro, 1 gato, 2 ave): ");
        int tipo;
        if (int.TryParse(Console.ReadLine(), out tipo))
        {
            paciente.Especie = (Especies)tipo;
        }

        GuardarArchivo(lista);

        Console.WriteLine("Paciente actualizado...");
    }

    public void Eliminar()
    {
        var lista = LeerArchivo();

        Console.Write("ID : ");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.WriteLine("valor invalido");
            return;
        }

        var paciente = lista.FirstOrDefault(p => p.Id == id);

        if (paciente == null)
        {
            Console.WriteLine("no encontrado");
            return;
        }

        lista.Remove(paciente);

        GuardarArchivo(lista);

        Console.WriteLine("paciente eliminado");
    }
}


class Program
{
    static void Main()
    {
        GestorPacientes gestor = new GestorPacientes();
        int opcion;

        do
        {
            Console.WriteLine("\n1. Crear | 2. listar | 3. modificar | 4. eliminar | 0. salir");
            Console.Write("seleccione: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("entra invalida ");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    gestor.Crear();
                    break;
                case 2:
                    gestor.Listar();
                    break;
                case 3:
                    gestor.Modificar();
                    break;
                case 4:
                    gestor.Eliminar();
                    break;
            }

        } while (opcion != 0);
    }
}