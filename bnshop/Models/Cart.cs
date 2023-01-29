using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace bnshop.Models
{
    public class Cart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int CartID { get; set; }
        public int Article_nbr { get; set; }
        public float Total { get; set; }

        public ICollection<Cartline> cartline { get; set; }
    }
}
