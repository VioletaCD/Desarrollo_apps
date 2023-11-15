public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
    if(contexto.Clientes.Any()) {
        return;
    }
    var clientes = new List<Cliente> {
        new Cliente { Nombre = "Alexander", Apeido = "Alvarez", Genero='H',FechaCumple = DateTime.Parse("2000-09-01"), Correo="alex@gmail.com", Telefono="4921303648"},
        new Cliente { Nombre = "Monse", Apeido = "Alonso", Genero='M', FechaCumple = DateTime.Parse("1980-09-01"), Correo="monse@gmail.com", Telefono="492004586"},
        new Cliente { Nombre = "Abraham", Apeido = "Valadez", Genero='H', FechaCumple = DateTime.Parse("1999-09-01"), Correo="abraham@gmail.com", Telefono="4921112233" },
        new Cliente { Nombre = "Gema", Apeido = "Valle", Genero='M', FechaCumple = DateTime.Parse("1970-09-01"), Correo="gema@gmail.com", Telefono="4921234560" },
        new Cliente { Nombre = "Yovanni", Apeido = "Mendez", Genero='H', FechaCumple = DateTime.Parse("1982-09-01"), Correo="yovanni@gmail.com", Telefono="4920123456" },
        new Cliente { Nombre = "Perla", Apeido = "Jimenez", Genero='M', FechaCumple = DateTime.Parse("1997-09-01"), Correo="perla@gmail.com", Telefono="4927654321" },
        new Cliente { Nombre = "Laura", Apeido = "Fernandez", Genero='M', FechaCumple = DateTime.Parse("2001-09-01"), Correo="laura@gmail.com", Telefono="4921112131" },
        new Cliente { Nombre = "Pablo", Apeido = "Flores", Genero='H', FechaCumple = DateTime.Parse("2000-09-01"), Correo="pablo@gmail.com", Telefono="4920665532" },
        new Cliente { Nombre = "Felipe", Apeido = "Lopez", Genero='H', FechaCumple = DateTime.Parse("1998-10-31"), Correo="felipe@gmail.com", Telefono="4921785644" }
    };
    contexto.Clientes.AddRange(clientes);
    contexto.SaveChanges();

    var habitaciones = new List<Habitacion>
        {
            new Habitacion {NoHab=12, Tipo = "Individual", Piso=1, Costo = 250.00},
            new Habitacion {NoHab=5, Tipo = "Doble", Piso=2, Costo = 500.00},
            new Habitacion {NoHab=7, Tipo = "Triple", Piso=2, Costo = 700.00},
            new Habitacion {NoHab=10, Tipo = "Individual", Piso=4, Costo = 250.00,},
            new Habitacion {NoHab=8, Tipo = "Doble", Piso=1, Costo = 500.00,},
            new Habitacion {NoHab=15, Tipo = "Triple", Piso=2, Costo = 700.00}
        };
        contexto.Habitaciones.AddRange(habitaciones);
        contexto.SaveChanges();

    var reservas = new List<Reserva> {
        new Reserva {InicioReserva = DateTime.Parse("2023-011-10"), FinReserva = DateTime.Parse("2023-11-15")},
        new Reserva {InicioReserva = DateTime.Parse("2023-11-11"), FinReserva = DateTime.Parse("2023-11-12")},
        new Reserva {InicioReserva = DateTime.Parse("2023-11-11"), FinReserva = DateTime.Parse("2023-11-18")},
        new Reserva {InicioReserva = DateTime.Parse("2023-11-15"), FinReserva = DateTime.Parse("2023-11-23")}
    };
    contexto.Reservas.AddRange(reservas);
    contexto.SaveChanges();
}
}