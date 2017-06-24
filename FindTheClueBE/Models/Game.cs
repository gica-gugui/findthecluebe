using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FindTheClueBE.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public int Difficulty { get; set; }

        [Required]
        public double Rating { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int RatingCounter { get; set; }

        public ICollection<Question> Question { get; set; }
    }
}