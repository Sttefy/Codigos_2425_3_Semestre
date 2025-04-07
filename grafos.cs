namespace MiGrafo
{
    class Grafos
    {
        Grafo grafo = new Grafo();
        class Grafo
        {
            private Dictionary<string, List<string>> adyacencia;

            public Grafo()
            {
        adyacencia = new Dictionary<string, List<string>>();
        InicializarGrafo();
        MostrarGrafo(); // Llama al método para mostrar el grafo al crear la instancia
    }

    // Método para inicializar el grafo con nombres de personas
    private void InicializarGrafo()
    {
        AgregarVertice("Rebeca");
        AgregarVertice("José");
        AgregarVertice("Alissa");
        AgregarVertice("Antonio");

        AgregarArista("Rebeca", "José");
        AgregarArista("José", "Alissa");
        AgregarArista("Alissa", "Antonio");
        AgregarArista("Rebeca", "Antonio");
    }

    // Método para agregar un vértice
    public void AgregarVertice(string nodo)
    {
        // Compara los nodos de forma insensible a mayúsculas
        foreach (var key in adyacencia.Keys)
        {
            if (String.Compare(key, nodo, StringComparison.OrdinalIgnoreCase) == 0)
                return; // El nodo ya existe
        }
        adyacencia[nodo] = new List<string>();
    }

    // Método para agregar una arista
    public void AgregarArista(string origen, string destino)
    {
        // Compara los nodos de forma insensible a mayúsculas
        string? nodoOrigen = null;
        string? nodoDestino = null;

        foreach (var key in adyacencia.Keys)
        {
            if (String.Compare(key, origen, StringComparison.OrdinalIgnoreCase) == 0)
                nodoOrigen = key;
            if (String.Compare(key, destino, StringComparison.OrdinalIgnoreCase) == 0)
                nodoDestino = key;
        }

        if (nodoOrigen != null && nodoDestino != null)
        {
            adyacencia[nodoOrigen].Add(nodoDestino);
            adyacencia[nodoDestino].Add(nodoOrigen); // Grafo no dirigido
        }
        else
        {
            Console.WriteLine("Uno o ambos nodos no existen en el grafo.");
        }
    }

    // Método para mostrar el grafo
    public void MostrarGrafo()
    {
        foreach (var nodo in adyacencia)
        {
            Console.Write(nodo.Key + " está conectado con: ");
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