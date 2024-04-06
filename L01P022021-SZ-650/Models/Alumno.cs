using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P022021_SZ_650.Models;

public partial class Alumno
{
    public int Id { get; set; }

    [Display(Name = "Código")]
    [MaxLength(10)]
    public string? Codigo { get; set; }

    [MaxLength(50)]
    public string? Nombre { get; set; }

    [MaxLength(50)]
    public string? Apellidos { get; set; }

    [Display(Name = "DUI")]
    public int? Dui { get; set; }

    public int? Estado { get; set; }
}
