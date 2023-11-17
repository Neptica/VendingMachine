using System;
using static System.Console;

public class Product
{
  private string description;
  private double price;

  public Product(string aDescription, double aPrice)
  {
    description = aDescription;
    price = aPrice;
  }

  public string getDescription()
  {
    return description;
  }

  public double getPrice()
  {
    return price;
  }

  //what does this do??
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
