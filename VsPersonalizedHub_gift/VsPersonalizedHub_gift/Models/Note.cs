using System.ComponentModel.DataAnnotations;

namespace VsPersonalizedHub_gift.Models;

public class Note
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; }

    [Required]
    public string Content { get; set; }

    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
}