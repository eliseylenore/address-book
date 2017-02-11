using System.Collections.Generic;
using System;

namespace AddressBook.Objects
{
  public class Contact
  {
    private static List<Contact> _contacts = new List<Contact> {};
    private string _name;
    private int _id;
    private List<Number> _numbers;
    private List<Address> _addresses;

    public Contact(string contactName)
    {
      _name = contactName;
      _contacts.Add(this);
      _id = _contacts.Count;
      _numbers = new List<Number>{};
      _addresses = new List<Address>{};
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      newName = _name;
    }
    public int GetId()
    {
      return _id;
    }

    public List<Number> GetNumbers()
    {
      return _numbers;
    }
    public void AddNumber(Number number)
    {
      _numbers.Add(number);
    }
    public List<Address> GetAddresses()
    {
      return _addresses;
    }
    public void AddAdress(Address address)
    {
      _addresses.Add(address);
    }
    public static List<Contact> GetAll()
    {
      return _contacts;
    }
    public static void ClearAll()
    {
      _contacts.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _contacts[searchId-1];
    }
    public static Contact Search(string searchString)
    {
      foreach (Contact person in _contacts) {
        if (person._name.ToLower() == searchString.ToLower())
        {
          return person;
        }
      }
      return null;
    }
  }
}
