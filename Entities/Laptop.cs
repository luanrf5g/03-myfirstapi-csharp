using System;

namespace _02_myfirstapi_c_.Entities;

public class Laptop : Device
{
  public override string GetBrand()
  {
    return "Apple";
  }

  public string GetModel()
  {
    var isConnected = IsConnected();
    if (isConnected)
      return "MacBook";

    return "unknown";
  }

  public override string Hello()
  {
    return "Hello World from Laptop";
  }
}
