 Console.Clear();
  Academia academia = new Academia {
            Nombre = "Academia de Futbol Club Deportivo Guadalajara",
            Propietario = "Violeta Calderón",
            Domicilio = "Centro Del Mundo 888"
        };
//DATOS PRIMERA CATEGORIA
        Categoria categoria1 = new Categoria{Nombre = "Sub-10",Rango = "2006/2007/2008",Costo = 1250};

        Jugador jugador1 = new Jugador{Nombre = "Alexander Lopez",AñoNac = 2006,Sexo = 'M',Becado = false};
        Jugador jugador2 = new Jugador{Nombre = "Uriel Puga",AñoNac = 2007,Sexo = 'M',Becado = true};
        Jugador jugador3 = new Jugador{Nombre = "Alejandra Escalona",AñoNac = 2008,Sexo = 'F',Becado = false};

        categoria1.Jugadores.Add(jugador1);
        categoria1.Jugadores.Add(jugador2);
        categoria1.Jugadores.Add(jugador3);

 //DATOS SEGUNDA CATEGORIA     
       Categoria categoria2 = new Categoria {Nombre = "Sub-12",Rango = "2009/2010/2011",Costo = 850};

        Jugador jugador4 = new Jugador{Nombre = "Armando Santana",AñoNac = 2009,Sexo = 'M',Becado = false};
        Jugador jugador5 = new Jugador{Nombre = "Daniel Mijares",AñoNac = 2010,Sexo = 'M',Becado = false};
        Jugador jugador6 = new Jugador{Nombre = "Antonio Hernandez",AñoNac = 2011,Sexo = 'M',Becado = true};

        categoria2.Jugadores.Add(jugador4);
        categoria2.Jugadores.Add(jugador5);
        categoria2.Jugadores.Add(jugador6);

       

//DATOS Tercera CATEGORIA     
     Categoria categoria3 = new Categoria {Nombre = "Sub-15",Rango = "2012/2013/2014",Costo = 700};

        Jugador jugador7 = new Jugador{Nombre = "Andrea Solis",AñoNac = 2012,Sexo = 'F',Becado = true};
        Jugador jugador8 = new Jugador{Nombre = "Marissa Hernandez",AñoNac = 2013,Sexo = 'F',Becado = true};
        Jugador jugador9 = new Jugador{Nombre = "Diana Soto",AñoNac = 2014,Sexo = 'F',Becado = false};

        categoria3.Jugadores.Add(jugador7);
        categoria3.Jugadores.Add(jugador8);
        categoria3.Jugadores.Add(jugador9);

        academia.Categorias.Add(categoria1);
        academia.Categorias.Add(categoria2);
        academia.Categorias.Add(categoria3);


        ImprimirInforme(academia);

        Console.ReadKey();


    static void ImprimirInforme(Academia academia)
    {
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("             >>>REPORTE DEL CLUB DEPORTIVO<<<                          ");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine($"Academia: {academia.Nombre}");
        Console.WriteLine($"Propietario: {academia.Propietario}");
        Console.WriteLine($"Domicilio: {academia.Domicilio}");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine(">> Datos generales de las Categorias");
        Console.WriteLine("");

        foreach (var categoria in academia.Categorias)
        {
            Console.WriteLine($"Categoría: {categoria.Nombre}");
            Console.WriteLine($"Rango: {categoria.Rango}");
            Console.WriteLine($"Costo: ${categoria.Costo}");
            Console.WriteLine("----------------------------------------------------");

            foreach (var jugador in categoria.Jugadores)
            {
                Console.WriteLine($"Nombre: {jugador.Nombre}");
                Console.WriteLine($"Año de Nacimiento: {jugador.AñoNac}");
                Console.WriteLine($"Sexo: {jugador.Sexo}");
                Console.WriteLine($"Becado: {(jugador.Becado ? "Sí" : "No")}");
                Console.WriteLine();
            }

            Console.WriteLine($"Total de Jugadores: {categoria.Jugadores.Count}");
            Console.WriteLine($"Total de Hombres: {categoria.TotalHombres()}");
            Console.WriteLine($"Total de Mujeres: {categoria.TotalMujeres()}");
            Console.WriteLine($"Subtotal del Costo: ${categoria.SubtotalCosto()}");
            Console.WriteLine("----------------------------------------------------");
        }

        Console.WriteLine($"Total de Categorías: {academia.TotalCategorias()}");
        Console.WriteLine($"Total de Hombres en la Academia: {academia.TotalHombres()}");
        Console.WriteLine($"Total de Mujeres en la Academia: {academia.TotalMujeres()}");
        Console.WriteLine($"Total de Ingresos: ${academia.TotalIngresos()}");
        Console.WriteLine("----------------------------------------------------");
    }


