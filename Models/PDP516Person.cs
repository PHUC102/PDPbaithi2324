
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PDPbaithi2324.Models;

    [Table("Person")]
public class Person
{
    
    [Key]
    public string? PersonId { get; set; }
    public  int Age { get; set; }
    public float Height { get; set; }
}



    


