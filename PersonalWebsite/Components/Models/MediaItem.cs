namespace PersonalWebsite.Components.Models;
using System.ComponentModel.DataAnnotations;

public class MediaItem
{
    [Key] // Tells EF Core this is the primary key
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string? Description { get; set; } // Optional description

    [Required]
    public string FilePathOrUrl { get; set; } // Path/URL to the actual image/video file

    [Required]
    public MediaType Type { get; set; } // Use an Enum for type safety

    [Required]
    public string Topic { get; set; } // e.g., "Live Performance", "Studio", "Promo", "Behind the Scenes"

    public DateTime DateAdded { get; set; } = DateTime.UtcNow;

    // Optional: Add properties like DateTaken, Location, ThumbnailUrl etc.
    // public string? ThumbnailUrl { get; set; }
}
