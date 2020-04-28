using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoMig.Entity
{
    public class Category
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public IList<Autopart> Autoparts { get; set; }
    }
}
