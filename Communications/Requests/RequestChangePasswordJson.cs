using System;

namespace _02_myfirstapi_c_.Communications.Requests;

public class RequestChangePasswordJson
{
  public string CurrentPassword { get; set; } = string.Empty;

  public string NewPassword { get; set; } = string.Empty;
}
