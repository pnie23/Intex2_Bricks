namespace Intex2_Bricks.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Product p, int quantity)
        {
            CartLine? line = Lines
                .Where(x => x.Product.Product_Id == p.Product_Id)
                .FirstOrDefault();

            //has this item already been added to our cart?
            if (line == null)
            {
                Lines.Add(new CartLine()
                {
                    Product = p,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product p) => Lines.RemoveAll(x => x.Product.Product_Id == p.Product_Id);

        public virtual void Clear() => Lines.Clear();

        public decimal CalculateTotal() => Lines.Sum(x => 25 * x.Quantity);

        //each line consists of these three bits of info
        public class CartLine
        {
            public int CartLineId { get; set; }
            public Product Product { get; set; }
            public int Quantity { get; set; }
        }
    }
}
