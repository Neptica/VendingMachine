using System;
using static System.Console;

public class Coin
{
  private double value;
  private string name;
  public static Coin NICKEL = new Coin(.05, "nickel");
  public static Coin DIME = new Coin(.10, "dime");
  public static Coin QUARTER = new Coin(.25, "quarter");
  public static Coin DOLLAR = new Coin(1.0, "dollar");

  public Coin(double aValue, string aName)
  {
    value = aValue;
    name = aName;
  }
  public double getValue()
  {
    return value;
  }
  public string getName()
  {
    return name;
  }
}
