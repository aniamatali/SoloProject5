using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;


namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
    
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View(allContacts);
    }

    [HttpGet("/Contacts")]
    public ActionResult Contacts()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View(allContacts);
    }

    [HttpGet("/Contacts/new")]
    public ActionResult ContactForm()
    {
      return View();
    }

    [HttpPost("/Contacts")]
    public ActionResult AddContact()
    {
      Contact newContact = new Contact(Request.Form["new-name"],Request.Form["new-address"],Request.Form["new-number"]);
      List<Contact> allContacts = Contact.GetAll();
      return View("Contacts", allContacts);
    }

    [HttpGet("/Contacts/{id}")]
    public ActionResult ContactDetail(int id)
    {
      Contact ContactMod = Contact.Find(id);
      return View(ContactMod);
    }

    [HttpPost("/Contacts/list/clear")]
    public ActionResult ContactListClear()
    {
      Contact.ClearAll();
      return View();
    }
  }
}
