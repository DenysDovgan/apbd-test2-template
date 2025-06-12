﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apbd_test2_template.Models.Entities;

[Table("Doctor")]
public class Doctor
{
    [Key]
    [Column("IdDoctor")]
    public int Id { get; set; }
    
    [Required, MaxLength(100)]
    public string FirstName { get; set; } = null!;
    
    [Required, MaxLength(100)]
    public string LastName { get; set; } = null!;
    
    [Required, MaxLength(100)]
    public string Email { get; set; } = null!;
    
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}