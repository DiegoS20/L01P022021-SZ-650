using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P022021_SZ_650.Models;

public partial class Departamento
{
    public int Id { get; set; }

    [Display(Name = "Nombre departamento")]
    [MaxLength(50)]
    public string? Departamento1 { get; set; }
}
