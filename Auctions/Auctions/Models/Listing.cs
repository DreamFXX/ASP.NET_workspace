using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Auctions.Models;
public class Listing
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImagePath { get; set; }
    public bool IsSolid { get; set; }

    [Required]
    public string? IdentityUserId { get; set; }
    [ForeignKey("IdentityUserId")]
    public IdentityUser? User { get; set; }

    public List<Bid>? Bids { get; set; }
    public List<Comment>? Comments { get; set; }

}


