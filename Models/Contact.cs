using System.Colelctions.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _address;
    privatestring _number;
    private static List<Contact> _instances = new List<Contact> {};
    private int _id;

    public Contact (string name, string address, string number)
    {
      _name = name;
      _address = address;
      _number = number;
      _instances.Add(this);
      _id = _instances.Count;
    }

    
  }
}
