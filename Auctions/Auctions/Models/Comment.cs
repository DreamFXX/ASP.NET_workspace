using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Auctions.Models;

public class Comment
{
    public int Id { get; set; }

    public string Content { get; set; }

    [Required]
    public string? IdentityUserId { get; set; }

    [ForeignKey("IdentityUserId")]
    public IdentityUser? User { get; set; }

    public int? ListingId { get; set; }

    [ForeignKey("ListingId")]
    public Listing? Listing { get; set; }
}
