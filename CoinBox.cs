using System;
using static System.Console;
using System.Collections.Generic;

public class CoinBox
{
  private List<Coin> box;

  public CoinBox()
  {
    box = new List<Coin>();
  }

  public void addCoin(Coin c)
  {
    box.Add(c);
  }

  public void addCoins(CoinBox other)
  {
    box.AddRange(other.box);
  }

  public double getValue()
  {
    double total = 0;
    foreach (Coin c in box) total += c.getValue();
    return total;
  }

  // return total value???
  public void removeAllCoins()
  {
    box.Clear();
  }
}
