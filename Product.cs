using System;
using static System.Console;

public class Product
{
  private string description;
  private double price;
  private int quantity;

  public Product(string aDescription, double aPrice, int aQuantity)
  {
    description = aDescription;
    price = aPrice;
    Quantity = aQuantity;
  }

  public int Quantity { get; set; }

  public string getDescription()
  {
    return description;
  }

  public double getPrice()
  {
    return price;
  }

  public new bool Equals(object other)
  {
    if (other == null)
    {
      return false;
    }
    Product b = (Product)other;
    return description.Equals(b.description) && price == b.price;
  }

  public string toString()
  {
    string priceString = price.ToString("C");
    return description + " @ " + priceString;
  }
}
