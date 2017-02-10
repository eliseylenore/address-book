using System.Collections.Generic;
using System;

namespace AddressBook
{
  public class Address
  {
    private string _firstLine;
    private string _city;
    private string _state;
    private string _zip;

  public Address(string firstLine, string city, string state, string zip)
  {
    _firstLine = firstLine;
    _city = city;
    _state = state;
    _zip = zip;
  }

  public string GetFirstLine()
  {
    return _firstLine;
  }
  public void SetFirstLine(string newFirstLine)
  {
    _firstLine = newFirstLine;
  }
  public string GetCity()
  {
    return _city;
  }
  public void SetCity(string newCity)
  {
    _city = newCity;
  }
  public string GetState()
  {
    return _state;
  }
  public string SetState(string newState)
  {
    _state = newState;
  }
  public string GetZip()
  {
    return _zip;
  }
  public string SetZip(string newZip)
  {
    _zip = newZip;
  }
}
