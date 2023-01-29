using System;
using System.Collections.Generic;

namespace bnshop.Models
{
    public class Product
    {
            public int ID { get; set; }
            public string Name { get; set; }
            public float Price { get; set; }
            public string? url_image { get; set; }

            public ICollection<Cartline>? Cartline { get; set; }

    }
}
