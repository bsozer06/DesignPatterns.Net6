using DesignPatterns.Builder.BasicExample.Abstract;

namespace DesignPatterns.Builder.BasicExample.Concrete
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        private void Reset()
        {
            _product = new Product();
        }


        #region IBuilder parts

        // All production steps work with the same product instance.
        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartA2");
        }

        public void BuildPartC()
        {
            this._product.Add("PartA3");
        }

        #endregion

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }



    }
}
