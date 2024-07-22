public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order()
    {
        _products = new List<Product>();
    }

    public double CalculateTotal()
    {
        double totalSum = 0;
        foreach (Product product in _products)
        {
            totalSum += product.Total();
        }

        if (_customer.Usa())
        {
            totalSum += 5; // This code will add $5 Shipping cost for customers in the USA
        }
        else
        {
            totalSum += 35; // This code will add $35 Shipping cost for customers outside the USA
        }

        return totalSum;
    }

    // this code will display a string value of the name and 
    // product Id as the packing label for the order
    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"\n Product-Name: {product.SetName()}, Product ID: {product.ProductId()} ";
        }

        return packingLabel;
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetCustomerInfo()}, {_customer.GetCustomerAddress()}";
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void AddCustomer(Customer customer)
    {
        _customer = customer;
    }
}
