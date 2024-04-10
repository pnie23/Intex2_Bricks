namespace Intex2_Bricks.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines
                .Where(p => p.Product.product_Id == product.product_Id)
                .FirstOrDefault();

            //has this item already been added to our cart?
            if (line == null)
            {
                Lines.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product) => Lines.RemoveAll(l => l.Product.product_Id == product.product_Id);

        public virtual void Clear() => Lines.Clear();

        public decimal CalculateTotal() => (decimal)Lines.Sum(e => e.Product.price * e.Quantity);

        //each line consists of these three bits of info
        public class CartLine
        {
            public int CartLineId { get; set; }
            public Product Product { get; set; }
            public int Quantity { get; set; }
        }
    }
}
