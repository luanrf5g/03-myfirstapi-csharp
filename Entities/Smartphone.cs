using System;

namespace _02_myfirstapi_c_.Entities;

public class Smartphone : Device
{
  public override string GetBrand()
  {
    return "Samsung";
  }
}
