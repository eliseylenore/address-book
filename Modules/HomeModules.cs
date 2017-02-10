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
    }
  }
}
