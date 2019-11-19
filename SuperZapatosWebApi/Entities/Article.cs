using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperZapatosWebApi.Entities
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total_in_shelf { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total_in_value { get; set; }
        public int Store_id { get; set; }
        public Store Store { get; set; }
    }
}
