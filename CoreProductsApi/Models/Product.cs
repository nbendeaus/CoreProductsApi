using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProductsApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string PName { get; set; }
        public string Loc { get; set; }
    }
}
