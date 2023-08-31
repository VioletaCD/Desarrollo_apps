 //Programa venta de articulos

           double totalVentas = 0;
            double totalIvaCobrado = 0;
            string respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("Programa de venta de articulos\n");
                double subtotalVenta = CalcularVenta();
                CalcularTotales(subtotalVenta, ref totalVentas, ref totalIvaCobrado);

                Console.Write("¿Desea ingresar otra venta? (S/N): ");
                respuesta = Console.ReadLine();

            } while (respuesta.ToUpper() == "S");

            MostrarTotales(totalVentas, totalIvaCobrado);

            Console.WriteLine("¡Gracias por utilizar nuestro sistema!");

            Console.ReadLine();

        static double CalcularVenta()
        {
            Console.Write("Ingrese la cantidad de artículos a vender: ");
            int cantidadArticulos = Convert.ToInt32(Console.ReadLine());

            double subtotalVenta = 0;

            for (int i = 1; i <= cantidadArticulos; i++)
            {
                Console.WriteLine($"Artículo {i}:");
                Console.Write("Ingrese la cantidad: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el precio unitario: ");
                double precio = Convert.ToDouble(Console.ReadLine());

                double subtotalArticulo = cantidad * precio;
                subtotalVenta += subtotalArticulo;
            }

            return subtotalVenta;
        }

        static void CalcularTotales(double subtotalVenta, ref double totalVentas, ref double totalIvaCobrado)
        {
            if (subtotalVenta > 1200)
            {
                totalVentas += subtotalVenta;
            }
            else
            {
                double iva = subtotalVenta * 0.16;
                totalVentas += subtotalVenta + iva;
                totalIvaCobrado += iva;
            }
        }

        static void MostrarTotales(double totalVentas, double totalIvaCobrado)
        {
            Console.WriteLine($"Total de Ventas: {totalVentas}");
            Console.WriteLine($"Total de IVA Cobrado: {totalIvaCobrado}");
        }
