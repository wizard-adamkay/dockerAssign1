using System.ComponentModel.DataAnnotations;

namespace assign1.Models
{
    public class Team
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}