using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_NavigationProperty.Models;

[Table("table_student")]
public class Student
{
    [Column("student_id")]
    public int Id { get; set; }

    [Column("person_id")]
    [Required]
    public int PersonId { get; set; }

    [Column("faculty")] 
    [Required]
    public string Faculty { get; set; }
    
    public Person Person { get; set; }
}