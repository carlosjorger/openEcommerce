using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenEcommerce_Backend.Models
{
    public class Product
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Photo { get; set; }
    }
}
