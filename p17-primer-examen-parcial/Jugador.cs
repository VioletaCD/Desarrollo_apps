public class Jugador
{
    public string Nombre { get; set; }
    public int AñoNac { get; set; }
    public char Sexo { get; set; }
    public bool Becado { get; set; }

    public void GenerarReporte()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Año de Nacimiento: {AñoNac}");
        Console.WriteLine($"Sexo: {Sexo}");
        Console.WriteLine($"Becado: {Becado}");
        Console.WriteLine();
    }
}

