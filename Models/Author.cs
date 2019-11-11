
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Core_Books.Models{

[Table("Author", Schema="dbo")]
public class Author
{
    [Key]
    public Guid AuthorId { get; set; }
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(50)]
    public string Genre { get; set; }
    public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}