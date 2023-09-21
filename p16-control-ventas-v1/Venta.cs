//Clase venta
class Venta
{
    public string Articulo { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }

    public Venta(string articulo, int cantidad, double precio)
    {
        Articulo = articulo;
        Cantidad = cantidad;
        Precio = precio;
    }

    public double CalcularTotal()
    {
        return Cantidad * Precio;
    }
}
