using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_NavigationProperty.Models;

[Table("table_students")]
public class Student
{
    [Column("student_id")]
    public int Id { get; set; }

    [Column("person_id")]
    [Required]
    public int PersonId { get; set; }

    [Column("faculty_id")] 
    [Required]
    public int FacultyId { get; set; }
    
    [ForeignKey(nameof(PersonId))]
    [Required]
    public virtual Person Person { get; set; }
    
    [ForeignKey(nameof(FacultyId))]
    [Required]
    public virtual Faculty Faculty { get; set; }
}