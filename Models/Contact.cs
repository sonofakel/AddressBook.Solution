using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _number;
    private string _address;
    private int _id;

    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string name = "", string number = "", string address = "")
    {
      _name = name;
      _number = number;
      _address = address;
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
    public string GetNumber()
    {
      return _number;
    }
    public void SetNumber(string newNumber)
    {
      _number = newNumber;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
