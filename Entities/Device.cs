using System;

namespace _02_myfirstapi_c_.Entities;

public abstract class Device
{
  protected bool IsConnected() => true;

  public abstract string GetBrand();
}
