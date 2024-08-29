using System.ComponentModel.DataAnnotations;

namespace OnlineBookstoreAssignment.Models;

public class Book
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string Genre { get; set; }
    public string Price { get; set; }
    public string Quantity { get; set; }
    
    public string Description { get; set; }
    public string Category { get; set; }
    public string Image { get; set; }
}