//CLASE CLIENTE
class Cliente
{
    public string Nombre { get; set; }
    public string RFC { get; set; }
    public string Domicilio { get; set; }
    public string Correo { get; set; }
    public List<Venta> Ventas { get; private set; }

    public Cliente(string nombre, string rfc, string domicilio, string correo)
    {
        Nombre = nombre;
        RFC = rfc;
        Domicilio = domicilio;
        Correo = correo;
        Ventas = new List<Venta>();
    }

    public void AgregarVenta(Venta venta)
    {
        Ventas.Add(venta);
    }

    public double CalcularSubtotal()
    {
        double subtotal = 0;

        foreach (Venta venta in Ventas)
        {
            subtotal += venta.CalcularTotal();
        }

        return subtotal;
    }
}
