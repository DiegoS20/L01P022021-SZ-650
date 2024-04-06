using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P022021_SZ_650.Models;

public partial class Facultade
{
    public int Id { get; set; }

    [Display(Name = "Nombre de la facultad")]
    [MaxLength(100)]
    public string? Facultad { get; set; }
}
