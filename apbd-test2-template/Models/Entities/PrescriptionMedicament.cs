﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace apbd_test2_template.Models.Entities;

[Table("Prescription_Medicament")]
[PrimaryKey(nameof(PrescriptionId), nameof(MedicamentId))]
public class PrescriptionMedicament
{
    public int PrescriptionId { get; set; }
    
    public int MedicamentId { get; set; }
    
    public int? Dose { get; set; }
    
    [Required, MaxLength( 100 )]
    public string Details { get; set; } = null!;
    
    public Prescription Prescription { get; set; } = null!;
    public Medicament Medicament { get; set; } = null!;
}