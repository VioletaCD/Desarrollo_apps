
using System;
using System.ComponentModel.DataAnnotations;

// Articulo.cs
public class Articulo
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "La descripción es requerida.")]
    [StringLength(25, MinimumLength = 3, ErrorMessage = "La descripción debe tener entre 3 y 25 caracteres.")]
    public string Descripcion { get; set; }

    [Required(ErrorMessage = "La fecha de alta es requerida.")]
    [Range(typeof(DateTime), "01/01/2023", "31/12/2024", ErrorMessage = "La fecha de alta debe estar en el rango 01/01/2023 a 31/12/2024.")]
    public DateTime FechaAlta { get; set; }

    [Required(ErrorMessage = "La cantidad es requerida.")]
    [Range(1, 100, ErrorMessage = "La cantidad debe estar en el rango de 1 a 100.")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "El precio es requerido.")]
    [Range(1, 2500, ErrorMessage = "El precio debe estar en el rango de 1 a 2500.")]
    public double Precio { get; set; }

    [Required(ErrorMessage = "La unidad de medida es requerida.")]
    public string UdeMedida { get; set; }
}
