namespace apbd_test2_template.Models.DTOs;

public class PrescriptionSummaryDto
{
    public int IdPrescription { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public DoctorDto Doctor { get; set; } = null!;
    public List<MedicamentSummaryDto> Medicaments { get; set; } = new();
}