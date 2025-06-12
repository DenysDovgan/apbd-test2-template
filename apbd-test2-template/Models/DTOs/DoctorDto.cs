namespace apbd_test2_template.Models.DTOs;

public class DoctorDto
{
    public int IdDoctor { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
}