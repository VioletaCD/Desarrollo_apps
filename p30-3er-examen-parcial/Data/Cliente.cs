using System.ComponentModel.DataAnnotations;
public class Cliente {
    public int Id {get; set;}
    [Required, StringLength(30)]
    public string Nombre {get; set;}
    [Required, StringLength(30)]
    public string Apeido {get; set;}
    public char Genero {get; set;}
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime FechaCumple {get; set;}
    [EmailAddress]
    public string Correo {get; set;}
    [RegularExpression(@"^\d{10}$", ErrorMessage = "El número de teléfono debe tener exactamente 10 dígitos.")]
    public string Telefono {get; set;}
    [Display(Name = "Nombre Completo")]
    public string NombreCompleto {
        get { return Nombre + " " + Apeido; }
    }
    public ICollection<Reserva> Reservas {get; set;} // modela la relación de 1 a muchos

    DateTime FechaHoy = DateTime.Today;

    
    public int ObtenerEdadEnAños(){
            var hoy = DateTime.Today;
            var edad = hoy.Year - FechaCumple.Year;

            // Restar un año si aún no ha pasado el cumpleaños este año
            if (FechaCumple.Date > hoy.AddYears(-edad))
                edad--;

            return edad;
        }
}