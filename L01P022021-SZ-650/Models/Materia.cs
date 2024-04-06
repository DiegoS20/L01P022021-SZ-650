using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P022021_SZ_650.Models;

public partial class Materia
{
    public int Id { get; set; }

    [Display(Name = "Nombre de la materia")]
    [MaxLength(100)]
    public string? Materia1 { get; set; }

    [Display(Name = "Unidades valorativas")]
    public int? UnidadesValorativas { get; set; }

    [MaxLength(1)]
    public string? Estado { get; set; }
}
