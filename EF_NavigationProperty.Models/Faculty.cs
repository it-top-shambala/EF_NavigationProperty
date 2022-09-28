using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_NavigationProperty.Models;

[Table("table_faculties")]
public class Faculty
{
    [Column("faculty_id")]
    public int Id { get; set; }
    
    [Column("faculty_name")]
    [Required]
    public string Name { get; set; }

    public List<Student> Students { get; set; }
}