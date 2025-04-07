﻿using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Universidad Estatal Amazonica");
Console.WriteLine("=====================================");
Console.WriteLine("Mariuxi Stefania Gavilanez Gutierrez");
Console.WriteLine("Y");
Console.WriteLine("Luis Eduardo Argudo Guzman");
Console.WriteLine("=====================================");
Console.WriteLine("Tecnologias de la información");
Console.WriteLine("=====================================");
Console.WriteLine("Tercer Semestre");
Console.WriteLine("=====================================");
Console.WriteLine("Grafo de conexiones");
Console.WriteLine("=====================================");


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
