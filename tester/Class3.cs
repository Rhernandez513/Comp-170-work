using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester
{
  public class Contact
  {
    private string name;
    private string phone;
    private string email;
    public Contact(string name, string phone, string email)
    {
      this.name = name;
      this.phone = phone;
      this.email = email;
    }
    public string GetName()
    {
      return name;
    }
    public string GetPhone()
    {
      return phone;
    }
    public string GetEmail()
    {
      return email;
    }
    public void SetName(string newName)
    {
      this.name = newName;
    }
    public void SetPhone(string newPhone)
    {
      this.phone = newPhone;
    }
    public void SetEmail(string newEmail)
    {
      this.email = newEmail;
    }
    public void Print()
    {
      Console.WriteLine(ToString());
    }
    public override string ToString()
    {
      return string.Format("Name: {0}\nPhone: {1}\nEmail: {2}", name, phone, email);
    }
  }
}