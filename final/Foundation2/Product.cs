
public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    
    // This method will get the string attribute _name   
    public string GetName()
    {  

        return _name; 
    }

    // This method will return the string for GetName  
    // that means this can be called in other class to get the _name 
    public string SetName()
    {  
        return GetName();
    }

    // This wiil return a product id as  a number only
    public int ProductId()
    {
        return _productId; 
     
    }

        // this code will initialize all attribute passed in as a peramenter 
    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

     // this method will return the string value of paramental
    public string GetProductDetail()
    {
        return $" Name: {_name} | ID: {_productId} | Unit Price: {_price} | Quantity: {_quantity}";
    }

    // this return the string value 
    // it can be called by other class in the program
    public string DisplayProductInfo()
    {
        return GetProductDetail();
    }

    // this return the total monitry value of quantity times price 
    // of a product
    public double Total()
    {
        return _price * _quantity;
    }
}

