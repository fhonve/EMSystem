using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbcontext = new dbemsEntities();
            dbcontext.dbContacts.First(contact => contact.FullName == "Frode");
            dbcontext.dbContacts.Add(new dbContacts
            {
                Address = "hei",
            });
        }
    }
}
