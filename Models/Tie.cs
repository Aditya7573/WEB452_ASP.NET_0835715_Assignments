using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aditya_Tie.Models
{
    public class Tie
    {
        public int Id { get; set; } // Unique identifier for the tie

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Design { get; set; } // Design or style of the tie

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } // Date when the tie was released or manufactured

        [Required]
        [StringLength(30)]
        public string Material { get; set; } // Material of the tie (e.g., Silk, Polyester)

        [Required]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; } // Price of the tie

        public bool IsAvailable { get; set; } // Indicates whether the tie is currently available in stock

        [Required]
        public CustomRatingScale Rating { get; set; }
    }

    public enum CustomRatingScale
    {
        [Display(Name = "Poor")]
        One = 1,

        [Display(Name = "Fair")]
        Two = 2,

        [Display(Name = "Good")]
        Three = 3,

        [Display(Name = "Very Good")]
        Four = 4,

        [Display(Name = "Excellent")]
        Five = 5
    }
}


