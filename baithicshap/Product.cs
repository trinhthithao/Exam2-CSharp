namespace baithicshap
{
    public class Product
    {
        private string ProductID;
        private string ProductName;
        private int Price;

        public Product()
        {
        }

        public Product(string productId, string productName, int price)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
        }

        public string ProdctId
        {
            get => ProductID;
            set => ProductID = value;
        }

        public string ProductName1
        {
            get => ProductName;
            set => ProductName = value;
        }

        public int Price1
        {
            get => Price;
            set => Price = value;
        }
    }
}