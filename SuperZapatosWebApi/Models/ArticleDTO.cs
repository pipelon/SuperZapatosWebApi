using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperZapatosWebApi.Models
{
    public class ArticleDTO
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Total_in_shelf { get; set; }
        public decimal Total_in_value { get; set; }
        public StoreDTO Store { get; set; }
    }
}
