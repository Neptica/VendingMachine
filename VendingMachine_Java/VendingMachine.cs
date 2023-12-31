using System;
using static System.Console;
using System.Collections.Generic;

public class VendingMachine
{
  private List<Product> products;
  public CoinBox coins;
  public CoinBox currentCoins;

  public VendingMachine()
  {
    products = new List<Product>();
    coins = new CoinBox();
    currentCoins = new CoinBox();
  }

  public List<Product> getProductTypes()
  {
    List<Product> types = new List<Product>();
    for (int i = 0; i < products.Count; i++)
    {
      Product entry = products[i];
      types.Add(entry);
    }
    return types;
  }

  public void addProduct(Product p, int quantity)
  {
    for (int i = 0; i < quantity; i++)
    {
      products.Add(p);
    }
  }

  public double addCoin(Coin c)
  {
    currentCoins.addCoin(c);
    return currentCoins.getValue();
  }

  public string buyProduct(Product p)
  {
    for (int i = 0; i < products.Count; i++)
    {
      Product prod = products[i];
      if (prod == p)
      {
        double payment = currentCoins.getValue();
        if (p.getPrice() <= payment)
        {
          products.RemoveAt(i);
          coins.addCoins(currentCoins);
          currentCoins.removeAllCoins();
          return "OK";
        }
        else
        {
          return "Insufficient money";
        }
      }
    }
    return "No such product";
  }

  public double removeMoney()
  {
    double r = coins.getValue();
    coins.removeAllCoins();
    return r;
  }
}
