using System.ComponentModel.DataAnnotations;
public class Jugador{
    [Key]
    public int Id {get; set;}
    [Required]
    [MinLength(3, ErrorMessage="Longitud debe ser 3 a 30 caracteres")]
    [MaxLength(30,ErrorMessage="Longitud debe ser 3 a 30 caracteres")]
    public string Nombre {get; set;}
    [Range(typeof(DateTime),"01/01/2000", "31/12/2024", ErrorMessage="Fecha fuera de rango")]
    public DateTime FechaNac {get; set;}
    [Range(1,20,ErrorMessage="Numeros disponibles del 1 al 20")]
    public int NoPlayera {get; set;}
    public string Posicion {get; set;}
    public int Aparicion {get; set;}
    public int Goles {get;set;}
}