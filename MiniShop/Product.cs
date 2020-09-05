namespace MiniShop
{
    class Product
    {
        private int id;
        private string name;
        private string descr = string.Empty; // "";
        private double price;

        private bool promo = false;
        private bool active = true;

        public Product(int id, string name, double price, string descr="")
        {
            this.id = id; this.name = name; this.price = price; this.descr = descr;
        }
    }
}