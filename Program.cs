using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Universidad Estatal Amazonica");
Console.WriteLine("=====================================");
Console.WriteLine("Mariuxi Stefania Gavilanez Gutierrez");
Console.WriteLine("=====================================");
Console.WriteLine("Tecnologias de la información");
Console.WriteLine("=====================================");
Console.WriteLine("Tercer Semestre");
Console.WriteLine("=====================================");
Console.WriteLine("Grafo de conexiones");
Console.WriteLine("=====================================");


List<string> catalogoRevistas = new List<string>
{
    "Revista Ciencia Hoy",
    "Tecnología y Futuro",
    "Historia y Cultura",
    "Mundo Deportivo",
    "Arte y Diseño",
    "Salud y Bienestar",
    "Viajes y Aventura",
    "Economía Global",
    "Gastronomía Moderna",
    "Literatura Contemporánea"
};

void MostrarMenu()
{
    while (true)
    {
        Console.WriteLine("\nMenú:");
        Console.WriteLine("1. Buscar título");
        Console.WriteLine("2. Salir");
        Console.Write("Seleccione una opción: ");

        string opcion = Console.ReadLine();
        if (opcion == "1")
        {
            Console.Write("Ingrese el título a buscar: ");
            string titulo = Console.ReadLine();

            bool encontrado = BuscarTituloRecursivo(catalogoRevistas, titulo, 0);
            Console.WriteLine(encontrado ? "Encontrado" : "No encontrado");
        }
        else if (opcion == "2")
        {
            break;
        }
        else
        {
            Console.WriteLine("Opción inválida. Intente nuevamente.");
        }
    }
}

bool BuscarTituloRecursivo(List<string> catalogo, string titulo, int indice)
{
    if (indice >= catalogo.Count)
        return false;
    if (catalogo[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
        return true;
    return BuscarTituloRecursivo(catalogo, titulo, indice + 1);
}

// Llamada inicial al menú
MostrarMenu();

