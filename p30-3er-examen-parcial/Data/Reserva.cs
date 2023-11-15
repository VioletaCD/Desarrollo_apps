using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
public class Reserva {
    public int Id {get; set;}
    public int HabitacionId {get; set;}
    public int ClienteId {get; set;}
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime InicioReserva {get; set;}
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime FinReserva {get; set;}

    public Habitacion Habitacion {get; set;}
    public Cliente Cliente {get; set;}

    public int DiasReservados {
        get {
            DateTime inicio = InicioReserva; 
            DateTime fin = FinReserva;
            TimeSpan duracion = fin - inicio;
            return duracion.Days;
        }
    }   

    public double TotalDR{
        get{return DiasReservados;}
    }
    public override string ToString() => $"{Habitacion.Tipo}-{Habitacion.NoHab}-{Habitacion.Piso}-{Habitacion.Costo}";

    public double Total {
        get {
            DateTime inicio = InicioReserva; 
            DateTime fin = FinReserva;
            TimeSpan duracion = fin - inicio;
            int numeroDias = duracion.Days;
            double costoPorDia = Habitacion.Costo;
            return costoPorDia * numeroDias;
        }
    }
}