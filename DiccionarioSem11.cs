public static class Diccionario
{
    public static void diccionario()
    {
        
        Dictionary<string, string> español_ingles = new Dictionary<string, string>();
        español_ingles.Add("abrumar", "overwhelm");
        español_ingles.Add("bostezar", "yawn");
        español_ingles.Add("chispear", "sparkle");
        español_ingles.Add("desvelar", "unveil");
        español_ingles.Add("escabullirse", "slip away");
        español_ingles.Add("fingir", "pretend");
        español_ingles.Add("girar", "turn");
        español_ingles.Add("hojear", "browse");
        español_ingles.Add("indagar", "investigate");
        español_ingles.Add("jactarse", "boast");
        español_ingles.Add("lidiar", "to deal");
        español_ingles.Add("murmurar", "murmur");
        español_ingles.Add("navegar", "navigate");
        español_ingles.Add("otear", "scan");
        español_ingles.Add("palidecer", "turn pale");
        español_ingles.Add("quebrantar", "break");
        español_ingles.Add("reanudar", "resume");
        español_ingles.Add("susurrar", "whisper");
        español_ingles.Add("titubear", "hesitate");
        español_ingles.Add("ulular", "hoot");
        español_ingles.Add("vagar", "wander");
        español_ingles.Add("zambullirse", "dive");
        español_ingles.Add("Es", "It's");
        español_ingles.Add("es", "is");
        español_ingles.Add("dificil", "hard");
        español_ingles.Add("con", "with");
        español_ingles.Add("alguien", "someone");
        

        int opcion;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Traducir frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la frase: ");
                    string frase = Console.ReadLine();
                    string[] palabras = frase.Split(" ");

                    Console.WriteLine("Su frase traducida es:");
                    foreach (var item in palabras)
                    {
                        if (español_ingles.ContainsKey(item))
                        {
                            Console.WriteLine(español_ingles[item]);
                        }
                        else
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

                case 2:
                    Console.Write("Ingrese la palabra en español: ");
                    string palabraEspañol = Console.ReadLine();
                    Console.Write("Ingrese la traducción en inglés: ");
                    string palabraIngles = Console.ReadLine();
                    español_ingles[palabraEspañol] = palabraIngles;
                    Console.WriteLine("Palabra añadida al diccionario.");
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 0);
    }
}