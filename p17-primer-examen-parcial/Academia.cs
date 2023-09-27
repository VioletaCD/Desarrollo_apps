public class Academia
{
    public string Nombre { get; set; }
    public string Propietario { get; set; }
    public string Domicilio { get; set; }
    public List<Categoria> Categorias { get; set; } = new List<Categoria>();

    public int TotalCategorias()
    {
        return Categorias.Count;
    }

    public int TotalHombres()
    {
        int total = 0;
        foreach (var categoria in Categorias)
        {
            total += categoria.TotalHombres();
        }
        return total;
    }

    public int TotalMujeres()
    {
        int total = 0;
        foreach (var categoria in Categorias)
        {
            total += categoria.TotalMujeres();
        }
        return total;
    }

    public double TotalIngresos()
    {
        double total = 0;
        foreach (var categoria in Categorias)
        {
            total += categoria.SubtotalCosto();
        }
        return total;
    }

    public void GenerarReporte()
    {
        Console.WriteLine("Datos generales de la academia:");
        Console.WriteLine($"Nombre: {Nombre,-60}");
        Console.WriteLine($"Propietario: {Propietario,-10}");
        Console.WriteLine($"Domicilio: {Domicilio,-10}");
        Console.WriteLine($"Total de Categorías: {TotalCategorias()}");
        Console.WriteLine($"Total de Hombres: {TotalHombres()}");
        Console.WriteLine($"Total de Mujeres: {TotalMujeres()}");
        Console.WriteLine($"Total de Ingresos: {TotalIngresos()}");

        Console.WriteLine("\nDatos generales de las Categorías:");
        foreach (var categoria in Categorias)
        {
            categoria.GenerarReporte();
        }
    }
}
