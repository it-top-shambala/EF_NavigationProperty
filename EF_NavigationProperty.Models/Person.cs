using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_NavigationProperty.Models;

[Table("table_persons")]
public class Person
{
    [Column("person_id")]
    public int Id { get; set; }
    
    [Column("first_name")]
    [Required]
    public string FirstName { get; set; }
    
    [Column("last_name")]
    [Required]
    public string LastName { get; set; }
    
    [Column("date_of_birth")]
    [Required]
    public DateTime DateOfBirth { get; set; }

    public List<Student> Students { get; set; }
}