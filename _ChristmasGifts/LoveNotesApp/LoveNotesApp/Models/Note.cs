using System.ComponentModel.DataAnnotations;

namespace LoveNotesApp.Models;

public class Note
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? NoteText { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime Created { get; set; }
}
