using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Auctions.Models;

public class Bid
{
    public int Id { get; set; }
    public double Price { get; set; }

    [Required]
    public string? IdentityUserId { get; set; }
    [ForeignKey("IdentityUserId")]
    public IdentityUser? User { get; set; }

    public int? ListingId { get; set; }
    public Listing? Listing { get; set; }

}
