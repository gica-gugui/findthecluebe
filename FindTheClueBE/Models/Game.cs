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

        public int Difficulty { get; set; }

        public double Rating { get; set; }

        public string PictureUrl { get; set; }

        public int Duration { get; set; }

        public string Description { get; set; }

        public int RatingCounter { get; set; }

        public ICollection<Question> Question { get; set; }
    }
}