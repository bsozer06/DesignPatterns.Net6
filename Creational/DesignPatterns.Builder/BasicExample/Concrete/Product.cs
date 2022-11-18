namespace DesignPatterns.Builder.BasicExample.Concrete
{
    public class Product
    {
        private List<object> _products = new();

        public void Add(string part)
        {
            this._products.Add(part);
        }


        public string ListProduct()
        {
            string str = string.Empty;

            for (int i = 0; i < this._products.Count; i++)
            {
                str += this._products[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }

    }
}
