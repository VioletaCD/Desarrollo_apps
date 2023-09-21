//CLASE TIENDA
class Tienda
{
    public string Nombre { get; set; }
    public string Propietario { get; set; }
    public string Domicilio { get; set; }
    private List<Cliente> clientes;

    public Tienda(string nombre, string propietario, string domicilio)
    {
        Nombre = nombre;
        Propietario = propietario;
        Domicilio = domicilio;
        clientes = new List<Cliente>();
    }

    public void AgregarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    public void ImprimirReporte()
    {
        Console.WriteLine($"Datos de la tienda: {Nombre}, Propietario: {Propietario}, Domicilio: {Domicilio}");
        Console.WriteLine("Clientes:");

        foreach (Cliente cliente in clientes)
        {
            Console.WriteLine($"Nombre: {cliente.Nombre}, RFC: {cliente.RFC}, Domicilio: {cliente.Domicilio}, Correo: {cliente.Correo}");
            Console.WriteLine("Ventas:");

            foreach (Venta venta in cliente.Ventas)
            {
                Console.WriteLine($"Articulo: {venta.Articulo}, Cantidad: {venta.Cantidad}, Precio: {venta.Precio}");
            }

            Console.WriteLine($"Subtotal por cliente: {cliente.CalcularSubtotal()}");
        }

        Console.WriteLine($"Total de ventas de la tienda: {CalcularTotalVentas()}");
    }

    public double CalcularTotalVentas()
    {
        double totalVentas = 0;

        foreach (Cliente cliente in clientes)
        {
            totalVentas += cliente.CalcularSubtotal();
        }

        return totalVentas;
    }
}
