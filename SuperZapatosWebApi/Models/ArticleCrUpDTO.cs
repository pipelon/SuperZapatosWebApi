using SuperZapatosWebApi.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperZapatosWebApi.Models
{
    public class ArticleCrUpDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [NotZeroRequired]
        public decimal Price { get; set; }
        [NotZeroRequired]
        public decimal Total_in_shelf { get; set; }
        [NotZeroRequired]
        public decimal Total_in_value { get; set; }
        [NotZeroRequired]
        public int Store_id { get; set; }
    }
}
