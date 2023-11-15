using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
public class Habitacion {
    public int Id {get; set;}
    [Range(1,30,ErrorMessage="Numeros disponibles del 1 al 30")]
    public int NoHab {get; set;}
    [Range(1,10,ErrorMessage="Numeros disponibles del 1 al 10")]
    public string Tipo {get; set;}
    [Range(1,4,ErrorMessage="Numeros disponibles del 1 al 4")] 
    public int Piso {get; set;} 
    [Range(1,5000,ErrorMessage="Numeros disponibles del 1 al 5000")]
    public double Costo {get; set;} 
    public ICollection<Reserva> Reservas {get; set;} 
}