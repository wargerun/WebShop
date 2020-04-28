using System.ComponentModel.DataAnnotations;

namespace AutoMig.Entity
{
    public class Autopart
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Country { get; set; }
        public string Photo { get; set; }
        public ushort Available { get; set; }
        public decimal Price { get; set; }
        public string Discription { get; set; }

        public virtual Category Category { get; set; }
    }
}
