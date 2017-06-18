using System.ComponentModel.DataAnnotations;

namespace FindTheClueBE.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public int AnswerType { get; set; }

        [Required]
        public string Answer { get; set; }

        [Required]
        public string TextAnswer { get; set; }

        [Required]
        public double Score { get; set; }

        [Required]
        public string QuestionText { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public int GameId { get; set; }

        public Game Game { get; set; }
    }
}