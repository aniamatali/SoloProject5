using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _number;
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

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    //
    public string getAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    //
    public string getNumber()
    {
      return _number;
    }
    public void SetNumber(string newNumber)
    {
      _number = newNumber;
    }
    public int GetId()
    {
      return _id;
    }
    //
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    //
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
    //
  }
}
