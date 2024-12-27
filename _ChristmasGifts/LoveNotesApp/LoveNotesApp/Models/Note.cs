using System;

namespace LoveNotesApp.Models;

public class Note
{
    public int Id { get; set; }
    public string? Message { get; set; }
    public DateTime UnlockDate { get; set; }
    public bool IsUnlocked { get; set; }
}
