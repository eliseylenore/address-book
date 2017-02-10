using Nancy;
using System;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      Get["/contact/form"] = _ => View["contact_form.cshtml"];
      Post["/contact/new"] = _ => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        var newContact = new Contact(Request.Form["name"]);
        List<Number> contactNumbers = newContact.GetNumbers();
        var newNumber = new Number(Request.Form["number"]);
        contactNumbers.Add(newNumber);
        List<Address> contactAddresses = newContact.GetAddresses;
        var newAddress = new Address(Request.Form["first-line"], Request.Form["city"], Request.Form["state"], Request.Form["zip"]);
        contactAddresses.Add(newAddress);
        model.Add("numbers", contactNumbers);
        model.Add("addresses", contactAddresses);
        model.Add("contact", newContact);
        return View["contact.cshtml", model];
      }
    }
  }
}
