using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Solicitar nombre del proyecto
            Console.Write("Nombre del proyecto: ");
            string nombreProyecto = Console.ReadLine();

            // Crear carpeta principal
            Directory.CreateDirectory(nombreProyecto);

            // Crear subcarpetas
            string rutaDocumentos = Path.Combine(nombreProyecto, "documentos");
            string rutaImagenes = Path.Combine(nombreProyecto, "imagenes");
            string rutaCodigo = Path.Combine(nombreProyecto, "codigo");

            Directory.CreateDirectory(rutaDocumentos);
            Directory.CreateDirectory(rutaImagenes);
            Directory.CreateDirectory(rutaCodigo);

            // Solicitar descripción
            Console.Write("\nDescripción del proyecto: ");
            string descripcion = Console.ReadLine();

            // Ruta del archivo readme
            string rutaReadme = Path.Combine(rutaDocumentos, "readme.txt");

            // Guardar descripción en el archivo
            string contenido = "Descripción del proyecto:" + Environment.NewLine + descripcion;

            File.WriteAllText(rutaReadme, contenido);

            // Mostrar ruta absoluta
            string rutaAbsoluta = Path.GetFullPath(nombreProyecto);

            Console.WriteLine("\nProyecto creado correctamente.");
            Console.WriteLine(" Ruta del proyecto:");
            Console.WriteLine(rutaAbsoluta);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\n Ocurrió un error:");
            Console.WriteLine(ex.Message);
        }
    }
}