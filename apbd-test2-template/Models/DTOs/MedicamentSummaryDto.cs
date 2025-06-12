﻿namespace apbd_test2_template.Models.DTOs;

public class MedicamentSummaryDto
{
    public int IdMedicament { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int? Dose { get; set; }
}