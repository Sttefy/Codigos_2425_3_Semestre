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


ArbolBinario arbol = new ArbolBinario();

arbol.Insertar(10);
arbol.Insertar(5);
arbol.Insertar(15);
arbol.Insertar(3);
arbol.Insertar(7);

Console.WriteLine(arbol.Buscar(7) ? "Encontrado" : "No encontrado");

Console.WriteLine("Recorrido inorden:");
arbol.RecorrerInOrden(arbol.Raiz);
Console.WriteLine();

class Nodo
{
    public int Valor;
    public Nodo Izquierdo, Derecho;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = Derecho = null;
    }
}

class ArbolBinario
{
    public Nodo Raiz;

    public void Insertar(int valor)
    {
        Raiz = InsertarRecursivo(Raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
        else
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);

        return nodo;
    }

    public bool Buscar(int valor)
    {
        return BuscarRecursivo(Raiz, valor);
    }

    private bool BuscarRecursivo(Nodo nodo, int valor)
    {
        if (nodo == null)
            return false;

        if (nodo.Valor == valor)
            return true;

        return valor < nodo.Valor ? BuscarRecursivo(nodo.Izquierdo, valor) : BuscarRecursivo(nodo.Derecho, valor);
    }

    public void RecorrerInOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            RecorrerInOrden(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            RecorrerInOrden(nodo.Derecho);
        }
    }
}
