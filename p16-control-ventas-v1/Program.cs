Console.Clear();

        // Crear una tienda
        Tienda tienda = new Tienda("Tienda de la Esquina", "Juan Pérez", "123 Calle Principal");

        // Crear clientes y ventas
        Cliente cliente1 = new Cliente("Carla Castro Correa", "CCC5596050", "LOS LAURELES 2", "CARLAC@example.com");
        Cliente cliente2 = new Cliente("CESAR FERNANDEZ LOPEZ", "FLC965955", "LA ESCONDIDA 55", "CESAR.FER@example.com");

        Venta venta1 = new Venta("Articulo 1", 5, 10.0);
        Venta venta2 = new Venta("Articulo 2", 3, 8.0);
        Venta venta3 = new Venta("Articulo 3", 2, 15.0);
        Venta venta4 = new Venta("Articulo 4", 4, 12.0);

        // Agregar ventas a clientes
        cliente1.AgregarVenta(venta1);
        cliente1.AgregarVenta(venta2);

        cliente2.AgregarVenta(venta3);
        cliente2.AgregarVenta(venta4);

        // Agregar clientes a la tienda
        tienda.AgregarCliente(cliente1);
        tienda.AgregarCliente(cliente2);

        // Imprimir el reporte
        tienda.ImprimirReporte();
    

