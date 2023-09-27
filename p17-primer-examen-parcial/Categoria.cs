public class Categoria
{
    public string Nombre { get; set; }
    public string Rango { get; set; }
    public double Costo { get; set; }
    public List<Jugador> Jugadores { get; set; } = new List<Jugador>();

    public int TotalHombres()
    {
        int total = 0;
        foreach (var jugador in Jugadores)
        {
            if (jugador.Sexo == 'M')
            {
                total++;
            }
        }
        return total;
    }

    public int TotalMujeres()
    {
        int total = 0;
        foreach (var jugador in Jugadores)
        {
            if (jugador.Sexo == 'F')
            {
                total++;
            }
        }
        return total;
    }

    public double SubtotalCosto()
    {
        double subtotal = 0;
        foreach (var jugador in Jugadores)
        {
            if (!jugador.Becado)
            {
                subtotal += Costo;
            }
        }
        return subtotal;
    }

    public void GenerarReporte()
    {
        Console.WriteLine($"Categoría: {Nombre}");
        Console.WriteLine($"Rango: {Rango}");
        Console.WriteLine($"Costo: {Costo}");
        Console.WriteLine($"Total de Jugadores: {Jugadores.Count}");
        Console.WriteLine($"Total de Hombres: {TotalHombres()}");
        Console.WriteLine($"Total de Mujeres: {TotalMujeres()}");
        Console.WriteLine($"Subtotal del Costo: {SubtotalCosto()}");

        Console.WriteLine("Jugadores por Categoría:");
        foreach (var jugador in Jugadores)
        {
            jugador.GenerarReporte();
        }
    }
}
