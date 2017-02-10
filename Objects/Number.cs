using System.Collections.Generic;
using System;

namespace AddressBook
{
  public class Number
  {
    private string _number;

  public Number(string number)
  {
    _number = number;
  }

  public string GetNumber()
  {
    return _number;
  }
  public void SetName(string newNumber)
  {
    _number = newNumber;
  }
}
