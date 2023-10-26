public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
        if(contexto.Jugadores.Any()) {
        return;
    }
    var jugadores = new Jugador[] {
    new Jugador {Nombre="Juan de laFuente",FechaNac=DateTime.Parse("26/03/2001"),NoPlayera=1,Posicion="Lateral",Aparicion=20,Goles=2},
    new Jugador {Nombre="Santiago Jimenez",FechaNac=DateTime.Parse("01/06/2002"),NoPlayera=2,Posicion="Portero",Aparicion=22,Goles=1},
    new Jugador {Nombre="Pedro Rodriguez",FechaNac=DateTime.Parse("18/09/2003"),NoPlayera=3,Posicion="Defensa",Aparicion=21,Goles=3},
    new Jugador {Nombre="Roberto Arellano",FechaNac=DateTime.Parse("19/08/2004"),NoPlayera=4,Posicion="Central",Aparicion=19,Goles=8},
    new Jugador {Nombre="Luis Montoya",FechaNac=DateTime.Parse("21/12/2005"),NoPlayera=5,Posicion="Delantero",Aparicion=19,Goles=13}
    };
    contexto.Jugadores.AddRange(jugadores);
    contexto.SaveChanges();
    }
}