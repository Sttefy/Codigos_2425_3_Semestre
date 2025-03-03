public static class Colas
{
    public static void colas(){
Console.WriteLine("Asignación de asientos en un aparque de atracciones");

//Es una cola que almacena la cantidad de asientos
Queue<int> asientos = new Queue<int>();
int Total_de_asientos = 30; //Contiene el valor de asientos en entero

for (int i = 1; i<= Total_de_asientos; i++)
{
    asientos.Enqueue(i); //Ordena los números
}

//Queue strin almacena los nombres y list strin es la lista de los nombres
Queue<string> nombres = new Queue<string>(new List<string> 
{
    "Elena", "Joel", "Vanesa", "Esteban", "Dominic", "Jonathan", "Anibal", "Cristina", "Elba",
     "Yolanda", "Cristian", "Fernando", "Andrea", "Ligia", "Ruben", "Darwin", "Estrella", 
    "Daniela", "Juan", "Elisa", "Fabian", "Angel", "Jenny", "Maykel", "Gerardo", "Luisa", "Nayely", 
    "Josefina", "Paula", "Renata" });

Console.WriteLine("===========================================================");
Console.WriteLine(                 "Asignacion de asientos");
Console.WriteLine("===========================================================");

//El while nos da un bucle que se repite mientras haya personas y asientos disponibles
while (asientos.Count > 0 && nombres.Count > 0)
{
    int asiento = asientos.Dequeue(); //Nos da el primer asiento en la cola
    string cliente = nombres.Dequeue(); //Nos da el primer nombre en la cola
    Console.WriteLine($"Pase {cliente}, al asiento {asiento}"); //Imprime el nombre de la persona y el asiento que le corresponde
}

//Imprime el total de asientos asignados y controla que el coteo sea correcto
Console.WriteLine($"Han sido asignados {Total_de_asientos - asientos.Count} asientos."); 
    }
}