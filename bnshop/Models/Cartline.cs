namespace bnshop.Models
{
    public class Cartline
    {
        public int CartlineID { get; set; }
        public int QTE { get; set; }

        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }
}
