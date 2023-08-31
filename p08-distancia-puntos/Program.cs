// Programa que Calcula la distancia entre dos puntos

Console.WriteLine("Programa que Calcula la distancia entre dos puntos\n");
Console.Clear();

            Console.WriteLine("Ingrese las coordenadas del punto A:");
            Console.Write("Ax: ");
            double ax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ay: ");
            double ay = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese las coordenadas del punto B:");
            Console.Write("Bx: ");
            double bx = Convert.ToDouble(Console.ReadLine());
            Console.Write("By: ");
            double by = Convert.ToDouble(Console.ReadLine());

            double distancia = CalcularDistancia(ax, ay, bx, by);

            Console.WriteLine($"La distancia entre los puntos A y B es: {distancia:f2}");

        static double CalcularDistancia(double ax, double ay, double bx, double by)
        {
            double diferenciaX = ax - bx;
            double diferenciaY = ay - by;
            double distancia = Math.Sqrt(Math.Pow(diferenciaX, 2) + Math.Pow(diferenciaY, 2));
            return distancia;
        }
    


