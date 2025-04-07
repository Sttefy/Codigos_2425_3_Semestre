namespace MiGrafo2
{
    class Grafo
    {
        Grafo grafo = new Grafo();

grafo.AgregarVertice("Guayaquil");
grafo.AgregarVertice("Quito");
grafo.AgregarVertice("Cuenca");
grafo.AgregarVertice("Manta");

grafo.AgregarAristaDirigida("Guayaquil", "Quito");
grafo.AgregarAristaDirigida("Quito", "Cuenca");
grafo.AgregarAristaDirigida("Manta", "Guayaquil");

grafo.MostrarGrafo();

class Grafo
{
    private Dictionary<string, List<string>> adyacencia;

    public Grafo()
    {
        adyacencia = new Dictionary<string, List<string>>();
    }

    public void AgregarVertice(string nodo)
    {
        if (!adyacencia.ContainsKey(nodo))
            adyacencia[nodo] = new List<string>();
    }

    public void AgregarAristaDirigida(string origen, string destino)
    {
        if (adyacencia.ContainsKey(origen))
            adyacencia[origen].Add(destino);
    }

    public void MostrarGrafo()
    {
        Console.WriteLine("Grafo de conexiones:");
        foreach (var nodo in adyacencia)
        {
            Console.Write(nodo.Key + " -> ");
            foreach (var vecino in nodo.Value)
            {
                Console.Write(vecino + " ");
            }
            Console.WriteLine();
        }
    }
}

    }
}