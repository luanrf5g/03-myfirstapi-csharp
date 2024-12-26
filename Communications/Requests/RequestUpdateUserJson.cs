using System;

namespace _02_myfirstapi_c_.Communications.Requests;

public class RequestUpdateUserJson
{
  public string Name { get; set; } = string.Empty;

  public string Email { get; set; } = string.Empty;
}
