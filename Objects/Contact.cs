using System.Collections.Generic
using System

namespace AddressBook
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
  }
}
