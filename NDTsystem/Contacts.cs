using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSystem
{
    public class Contacts
    {
        public int ContactID { get; set; }

        public string FullName { get; set; }

        public string Birthday { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string ImageUrl { get; set; }
        
        public bool Type { get; set; }

        public string Phone { get; set; }

        public string Position { get; set; }
        
        public string Company { get; set; }
    }
}
