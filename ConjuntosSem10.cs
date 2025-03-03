public static class Conjuntos
{
    public static void conjuntos()
    {
        // Vacunas del Covid-19
        
        HashSet<string> ciudadanos = new HashSet<string>();
        HashSet<string> pfizer = new HashSet<string>();
        HashSet<string> astrazeneca = new HashSet<string>();

        Random aleatorio = new Random();

        try
        {
            StreamReader lector = new StreamReader ("nombres.txt");
            {
                String? linea;
                while ((linea = lector.ReadLine()) != null)
                {
                    ciudadanos.Add (linea);
                }
            }
        }
            catch (System.Exception e)
            {
                System.Console.WriteLine ("Habido un errror:" + e.Message);
            }

            List<string> listaCiudadanos = new List<string>(ciudadanos);
                for (int i = 0; i < 500; i++)
                {
                    int nombre = aleatorio.Next(listaCiudadanos.Count);
                    pfizer.Add(listaCiudadanos[nombre]);
                }

                for (int i = 0; i < 75; i++)
                {
                    int nombre = aleatorio.Next(listaCiudadanos.Count);
                    pfizer.Add(listaCiudadanos[nombre]);
                }

                for (int i = 0; i < 75; i++)
                {
                    int nombre = aleatorio.Next(listaCiudadanos.Count);
                    astrazeneca.Add(listaCiudadanos[nombre]);
                }

            HashSet<string> Interseccion = new HashSet<string>(ciudadanos);
            ciudadanos.IntersectWith(pfizer);
            ciudadanos.ExceptWith(astrazeneca);

            HashSet<string> interseccion = new HashSet<string>(pfizer);
            pfizer.IntersectWith(astrazeneca);

            HashSet<string> Diferencia = new HashSet<string>(astrazeneca);
            astrazeneca.ExceptWith(pfizer);

            HashSet<string> diferencia = new HashSet<string>(pfizer);
            pfizer.ExceptWith(astrazeneca);

            Console.WriteLine("Ciudadanos sin vacunar:");
            foreach (var item in Interseccion)
            {
                System.Console.WriteLine(item);
            }

            Console.WriteLine("Ciudadanos que tienen las dos vacunas:");
            foreach (var item in interseccion)
            {
                System.Console.WriteLine(item);
            }

            Console.WriteLine("Ciudadanos que solo estan vacunados con Astrazeneca:");
            foreach (var item in Diferencia)
            {
                System.Console.WriteLine(item);
            }

            Console.WriteLine("Ciudadanos que solo estan vacunados con Pfizer:");
            foreach (var item in diferencia)
            {
                System.Console.WriteLine(item);
            }
    }
}